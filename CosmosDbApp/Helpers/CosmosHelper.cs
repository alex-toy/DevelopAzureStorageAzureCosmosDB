using Microsoft.Azure.Cosmos;
using System;
using System.Threading.Tasks;

namespace Helpers
{
    public class CosmosHelper
    {
        private readonly string _connectionString;
        private readonly CosmosClient _cosmosclient;

        public CosmosHelper(string connectionString)
        {
            _connectionString = connectionString;
            _cosmosclient = new CosmosClient(_connectionString);
        }

        public async Task CreateDatabase(string databaseName)
        {
            await _cosmosclient.CreateDatabaseAsync(databaseName);
        }

        public async Task CreateContainer(string databaseName, string containerName, string partitionKey)
        {
            Database _cosmos_db = _cosmosclient.GetDatabase(databaseName);
            await _cosmos_db.CreateContainerAsync(containerName, partitionKey);
        }
    }
}
