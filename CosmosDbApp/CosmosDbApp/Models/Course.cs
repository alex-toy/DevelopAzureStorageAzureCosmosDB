using Helpers;
using System.Collections.Generic;

namespace CosmosDbApp.Models
{
    public class Course : IItem
    {
        public string id { get; set; }
        public string courseid { get; set; }
        public string coursename { get; set; }
        public decimal rating { get; set; }
        public string partitionKey { get => coursename; }
        public List<Order>? orders { get; set; }
    }
}
