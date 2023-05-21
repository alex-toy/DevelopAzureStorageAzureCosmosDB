using Azure.Data.Tables;
using System.Threading.Tasks;

namespace Helpers
{
    public class TableServiceHelper
    {
        private readonly string _connectionString;
        private readonly TableServiceClient _tableServiceClient;

        public TableServiceHelper(string connectionString)
        {
            _connectionString = connectionString;
            _tableServiceClient = new TableServiceClient(_connectionString);
        }

        public async Task CreateTable(string tableName)
        {
            //await _tableServiceClient.CreateTableAsync(tableName);

            TableClient tableClient1 = _tableServiceClient.GetTableClient(tableName: "adventureworks-1");

            await tableClient1.CreateAsync();
        }
    }
}
