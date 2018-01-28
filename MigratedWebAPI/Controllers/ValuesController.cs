using MigrateBusinessService;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace MigrateWebAPI2AzFunc.Controllers
{
    public class ValuesController : ApiController
    {
        private ValueService valueService;

        public ValuesController()
        {
            valueService = new ValueService();
        }
        // GET api/values
        public async Task<IEnumerable<string>> Get()
        {
            return await valueService.GetValueList();
        }

        // GET api/values/5
        public async Task<string> Get(int id)
        {
            return await valueService.GetValue(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            valueService.SetValue(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {

        }
    }
}
