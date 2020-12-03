using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs.Extensions.Storage;
using Microsoft.Extensions.Configuration;

namespace AzureFunctionTimerApp
{
    [StorageAccount("AzureWebJobsStorage")]
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer,
            [Queue("thequeue",Connection = "AzureWebJobsStorage")] out string QMessage, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            QMessage = "Time Triggered";
        }
    }
}
