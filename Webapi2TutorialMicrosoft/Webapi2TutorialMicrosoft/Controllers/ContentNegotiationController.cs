using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webapi2TutorialMicrosoft.Models;

namespace Webapi2TutorialMicrosoft.Controllers
{
//    The HTTP specification(RFC 2616) defines content negotiation as “the process of selecting the best representation for a given response when there are multiple representations available.” The primary mechanism for content negotiation in HTTP are these request headers:

//Accept: Which media types are acceptable for the response, such as “application/json,” “application/xml,” or a custom media type such as "application/vnd.example+xml"
//Accept-Charset: Which character sets are acceptable, such as UTF-8 or ISO 8859-1.
//Accept-Encoding: Which content encodings are acceptable, such as gzip.
//Accept-Language: The preferred natural language, such as “en-us”.
//The server can also look at other portions of the HTTP request.For example, if the request contains an X-Requested-With header, indicating an AJAX request, the server might default to JSON if there is no Accept header.

//In this article, we’ll look at how Web API uses the Accept and Accept-Charset headers. (At this time, there is no built-in support for Accept-Encoding or Accept-Language.)
    public class ContentNegotiationController : ApiController
    {
//        Serialization

//If a Web API controller returns a resource as CLR type, the pipeline serializes the return value and writes it into the HTTP response body.

//For example, consider the following controller action:

        public Product GetProduct(int id)
        {
            var item = new Product();// _products.FirstOrDefault(p => p.ID == id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }
    }
}
