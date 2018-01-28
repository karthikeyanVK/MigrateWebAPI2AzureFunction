using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using MigrateBusinessService;

namespace MigratedAzFunc
{
    public class GetValueHttpTrigger
    {
        public static async Task<string> Run(HttpRequestMessage req, IAsyncCollector<string> outputQueues, TraceWriter log)
        {
            ValueService valueService = new ValueService();
            log.Info("C# HTTP trigger function processed a request.");

            var body = await req.Content.ReadAsStringAsync().ConfigureAwait(false);
            var id = req.GetQueryNameValuePairs()
                       .FirstOrDefault(q => string.Compare(q.Key, "id", true) == 0).Value; ;
           var result = valueService.GetValue(int.Parse(id));
            
            // Make sure it returns HTTP Status Code of 202 (Accepted).
            return await result;
        }
    }
}