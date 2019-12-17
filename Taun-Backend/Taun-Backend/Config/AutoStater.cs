using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Taun_Backend.Config
{
    public static class AutoStater
    {
        [FunctionName("AutoStater")]
        public static void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
