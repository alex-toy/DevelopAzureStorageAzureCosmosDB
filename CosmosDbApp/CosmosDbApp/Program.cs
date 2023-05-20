using Helpers;
using System;
using System.Threading.Tasks;

namespace CosmosDbApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string connectionString = "AccountEndpoint=https://alexeiaccount.documents.azure.com:443/;AccountKey=kzM4Se9xmMk6OomcHp4mOeI0bJ95K9cbGQvxsIYfJGmZB6HmrkcmyG6kBOyaVlvFyfQl8rcC7PB3ACDbR4XJTg==;";
            CosmosHelper cosmos = new CosmosHelper(connectionString);

            string databaseName = "appdb";
            await cosmos.CreateDatabase(databaseName);

            string containerName = "course";
            string partitionKey = "/courseid";
            await cosmos.CreateContainer(databaseName, containerName, partitionKey);
        }
    }
}
