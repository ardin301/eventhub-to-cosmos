using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.EventHubs;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eventhub_to_cosmos
{
    public static class InsertToCosmos
    {
        [FunctionName("InsertToCosmos")]
        public static void Run([EventHubTrigger("entytysh", Connection = "ifenhab")] string eventSingular, 
            [CosmosDB(
                databaseName:"ToDoList",
                collectionName:"Items",
                ConnectionStringSetting = "cosmos"
            )] out Customer newCustomer,
            ILogger log)
        {
            var exceptions = new List<Exception>();
            newCustomer = JsonConvert.DeserializeObject<Customer>(eventSingular);
        }
    }
}
