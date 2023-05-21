using Helpers;
using System;

namespace SendDataToCosmosApp.Entities
{
    class Activity : IItem
    {
        public string id { get; set; }
        public string Correlationid { get; set; }
        public string Operationname { get; set; }
        public string Status { get; set; }
        public string Eventcategory { get; set; }
        public string Level { get; set; }

        public string partitionKey => Operationname;
    }
}
