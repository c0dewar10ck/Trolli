using Trolli.Models.Requests;
using Trolli.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Trolli.Web.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/routes")]
    public class RoutesApiController : ApiController
    {
        [Route, HttpPut]
        public HttpResponseMessage GetRoute(RouteRequest model)
        {
            WebClient client = new WebClient();
            ItemResponse<string> response = new ItemResponse<string>();
            response.Item = client.DownloadString(model.Url);
            return Request.CreateResponse(HttpStatusCode.OK, response);

        }

    }
}
