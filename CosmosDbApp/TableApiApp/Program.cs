using AzureStorage;
using Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using TableApiApp.Entities;

namespace TableApiApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            TableStorage();
        }

        public static void TableStorage()
        {
            string connectionString = "DefaultEndpointsProtocol=https;AccountName=alexeinewaccount2;AccountKey=IoKyrAZknC7scPInsSjwxJNiAE24g2PpGS5fDZIiYkwp7NGugik72cFmXnFJHv8YHz7UQFoqaZgjACDbsbop3w==;TableEndpoint=https://alexeinewaccount2.table.cosmos.azure.com:443/;";
            TableStorageHelper tableStorage = new TableStorageHelper(connectionString);

            string tableName = "customer";


            tableStorage.CreateTable(tableName);


            //Customer customer = new Customer("jérémie", "genève", "C4");
            //tableStorage.AddEntity(tableName, customer);


            List<Customer> customers = new List<Customer>
            {
                new Customer("alex", "paris", "C5"),
                new Customer("seb", "paris", "C6"),
                new Customer("kate", "paris", "C7"),
            };
            tableStorage.AddEntities(tableName, customers);


            //Customer customer = tableStorage.GetEntity<Customer>(tableName, "lyon", "C2");
            //Console.WriteLine($"The client with customerId {customer.RowKey} is called {customer.Name}");


            //Customer customer = new Customer("mathieux", "genève", "C4");
            //tableStorage.UpdateEntity<Customer>(tableName, customer);


            //Customer customer = tableStorage.GetEntity<Customer>(tableName, "lyon", "C2");
            //tableStorage.DeleteEntity<Customer>(tableName, customer);
        }
    }
}
