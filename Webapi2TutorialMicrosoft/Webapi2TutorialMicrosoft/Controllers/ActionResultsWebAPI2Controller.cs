using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using Webapi2TutorialMicrosoft.Custom;
using Webapi2TutorialMicrosoft.Models;

namespace Webapi2TutorialMicrosoft.Controllers
{
    //    A Web API controller action can return any of the following:

    //void
    //HttpResponseMessage
    //IHttpActionResult
    //Some other type
    //Depending on which of these is returned, Web API uses a different mechanism to create the HTTP response.

    //Return type How Web API creates the response
    //void Return empty 204 (No Content)
    //HttpResponseMessage Convert directly to an HTTP response message.
    //IHttpActionResult   Call ExecuteAsync to create an HttpResponseMessage, then convert to an HTTP response message.
    //Other type  Write the serialized return value into the response body; return 200 (OK).
    public class ActionResultsWebAPI2Controller : ApiController
    {
        Product[] products = new Product[]
         {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
         };
        public HttpResponseMessage Get()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "value");
            response.Content = new StringContent("hello", Encoding.Unicode);
            response.Headers.CacheControl = new CacheControlHeaderValue()
            {
                MaxAge = TimeSpan.FromMinutes(20)
            };
            return response;
        }
        //If you pass a domain model to the CreateResponse method, Web API uses a media formatter to write the serialized model into the response body.
        [HttpGet]
        [Route("GetProducts")]
        public HttpResponseMessage GetProducts()
        {
            // Write the list to the response body.
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, products);
            return response;
        }
        [Route("GetIHttpActionResult")]
        public IHttpActionResult GetIHttpActionResult()
        {
            return new TextResult("hello", Request);
        }

        //Other Return Types

        //  For all other return types, Web API uses a media formatter to serialize the return value.Web API writes the serialized value into the response body.The response status code is 200 (OK).
        [Route("GetIEnumerable")]
        public IEnumerable<Product> GetIEnumerable()
            {
                return products;
            }
        
    }
}
