using Helpers;
using SendDataToCosmosApp.Entities;
using System.IO;
using System.Threading.Tasks;

namespace SendDataToCosmosApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string connectionString = "AccountEndpoint=https://alexeiaccount.documents.azure.com:443/;AccountKey=kzM4Se9xmMk6OomcHp4mOeI0bJ95K9cbGQvxsIYfJGmZB6HmrkcmyG6kBOyaVlvFyfQl8rcC7PB3ACDbR4XJTg==;";
            CosmosHelper cosmos = new CosmosHelper(connectionString, false);


            string databaseName = "sendatadtocosmosb";
            //await cosmos.CreateDatabase(databaseName);


            string containerName = "activity";
            string partitionKey = "/Operationname";
            //await cosmos.CreateContainer(databaseName, containerName, partitionKey);


            string localFilePath = "C:\\source\\cSharpAzure\\DevelopAzureStorageAzureCosmosDB\\QueryResult.json";
            FileStream fs = new FileStream(localFilePath, FileMode.Open, FileAccess.Read);
            await cosmos.SendData<Activity>(databaseName, containerName, fs);
        }
    }
}
