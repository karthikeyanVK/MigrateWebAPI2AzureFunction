using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MigrateBusinessService
{
    public class ValueService
    {
        public async Task<IEnumerable<string>> GetValueList()
        {
             return await Task.FromResult<IEnumerable<string>>(new string[] { "value1", "value2" });
        }

        // GET api/values/5
        public async Task<string> GetValue(int id)
        {
            return await Task.FromResult<string>("value");
        }
        public void SetValue(string id)
        {
            Console.WriteLine($"value updated: {id}");
        }

    }
}
