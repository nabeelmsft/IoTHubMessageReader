using IoTHubTrigger = Microsoft.Azure.WebJobs.EventHubTriggerAttribute;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Azure.Messaging.EventHubs;
using System.Text;
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace IoTHub_EventHubReaderFunction
{
    public class IoTHub_EventHubReader
    {
        private static HttpClient client = new HttpClient();
        
        [FunctionName("IoTHub_EventHubReader")]
        public void Run([EventHubTrigger("iot-samples-hub", Connection = "EventHubConnection")]EventData message, ILogger log)
        {
            log.LogInformation($"C# IoT Hub trigger function processed a message: {message.Data}");
        }
    }
}