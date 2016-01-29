using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApp.Controllers.CarService
{
    public class CarServiceApiController : ApiController
    {
        // GET: api/CarServiceApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CarServiceApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CarServiceApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CarServiceApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CarServiceApi/5
        public void Delete(int id)
        {
        }
    }
}
