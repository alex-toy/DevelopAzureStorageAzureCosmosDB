using Microsoft.Azure.Cosmos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Helpers
{
    public class CosmosHelper
    {
        private readonly string _connectionString;
        private readonly CosmosClient _cosmosClient;

        public CosmosHelper(string connectionString)
        {
            _connectionString = connectionString;
            _cosmosClient = new CosmosClient(_connectionString, new CosmosClientOptions() { AllowBulkExecution = true });
        }

        public async Task CreateDatabase(string databaseName)
        {
            await _cosmosClient.CreateDatabaseAsync(databaseName);
        }

        public async Task CreateContainer(string databaseName, string containerName, string partitionKey)
        {
            Database _cosmos_db = _cosmosClient.GetDatabase(databaseName);
            await _cosmos_db.CreateContainerAsync(containerName, partitionKey);
        }

        public async Task AddItem<T>(string databaseName, string containerName, T item) where T : IItem
        {
            Container container = _cosmosClient.GetContainer(databaseName, containerName);
            await container.CreateItemAsync<T>(item, new PartitionKey(item.partitionKey));
        }

        public async Task Bulkinsert<T>(string databaseName, string containerName, List<T> items) where T : IItem
        {
            Container container = _cosmosClient.GetContainer(databaseName, containerName);
            List<Task> _tasks = new List<Task>();
            foreach (T item in items) _tasks.Add(container.CreateItemAsync<T>(item, new PartitionKey(item.partitionKey)));
            await Task.WhenAll(_tasks);
        }

        public async Task<List<T>> ReadData<T>(string databaseName, string containerName, string query) where T : IItem
        {
            Container container = _cosmosClient.GetContainer(databaseName, containerName);
            QueryDefinition _definition = new QueryDefinition(query);
            FeedIterator<T> _iterator = container.GetItemQueryIterator<T>(_definition);

            List<T> items = new List<T>();
            while (_iterator.HasMoreResults)
            {
                FeedResponse<T> result = await _iterator.ReadNextAsync();
                foreach (T item in result)
                {
                    items.Add(item);
                }
            }

            return items;
        }

        public async Task UpdateData<T>(string databaseName, string containerName, T newItem) where T : IItem
        {
            Container container = _cosmosClient.GetContainer(databaseName, containerName);
            await container.ReplaceItemAsync<T>(newItem, newItem.id, new PartitionKey(newItem.partitionKey));
        }

        public async Task DeleteData<T>(string databaseName, string containerName, T item) where T : IItem
        {
            Container container = _cosmosClient.GetContainer(databaseName, containerName);
            await container.DeleteItemAsync<T>(item.id, new PartitionKey(item.partitionKey));
        }
    }
}
