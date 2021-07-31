using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace AspDotNetFramework.Controllers
{
    /// <summary>
    /// Copy and paste from ASP.NET Core project.
    /// With a little bit of edit
    /// </summary>
    public class RouteFocuedController : ApiController
    {

        [HttpGet]
        public IHttpActionResult IamAnAction()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The route was set by the default value (set by the Web API Route Config)");
            return Ok(sb.ToString());
        }

        [HttpGet]
        [Route("ConstUrlRoute")]
        public IHttpActionResult ConstUrl()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("You called this URL by typing the [domain name]/ConstUrlRoute.");
            sb.AppendLine("The route was defined in Action level");
            return Ok(sb.ToString());
        }

        [HttpGet, Route("TryToGetMe", Name = "TryToGetMe Route Name")]
        public IHttpActionResult RouteByGetAttr()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This Route was created by using the [Route] Attribute");
            sb.AppendLine("In ASP.NET Framework, you cannot define the route the in Http Method Attribute");
            return Ok(sb.ToString());
        }

        [HttpPost, Route("TryToGetMeByPOST")]
        public IHttpActionResult RouteByPostAttr()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This Route was created by using the [Route] Attribute");
            sb.AppendLine("This Route was NOT created by using the [HttpPost] Attribute");
            sb.AppendLine("In ASP.NET Framework, you cannot define the route the in Http Method Attribute");
            return Ok(sb.ToString());
        }

        [HttpPut, Route("PutTheRoutePath")]
        public IHttpActionResult RouteByHeadAttr()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("You called this endpoint via Put Method");
            return Ok(sb.ToString());
        }

        [Route("NoHttpMethodAttr")]
        public IHttpActionResult NoMethodAttrRoute()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("if no Http Method Attribute was set, then all Http methods are valid");
            sb.AppendLine("as long as the route path is set.");
            sb.AppendLine("Try to call it with the most un-common Http methods and see that it still being called.");
            return Ok(sb.ToString());
        }
    }
}
