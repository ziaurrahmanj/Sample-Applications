using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiContentNegotiation.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
      
        public HttpResponseMessage GetProduct(int id)
        {
            var item = new Product() { Name = "Chai" };
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK, item);
        }
       

        // POST api/values
        public void Post([FromBody]string value)
        {
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
