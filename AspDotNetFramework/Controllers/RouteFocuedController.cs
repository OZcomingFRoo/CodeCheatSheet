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
    /// Copy and paste from ASP.NET Core project
    /// </summary>
    public class RouteFocuedController : ApiController
    {
        private readonly HttpApplicationState applicationState;

        public RouteFocuedController()
        {
            this.applicationState = HttpContext.Current.Application;
        }

        [HttpGet]
        public IHttpActionResult IamAnAction()
        {
            int s = applicationState.Count;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The route set on this Action was defined by the keywords:");
            sb.AppendLine("[controller] and [action]");
            sb.AppendLine("[controller] = \"RouteFocusedController\"");
            sb.AppendLine("[action] = \"IamAnAction\"");
            sb.AppendLine("Changing the name of either the controller or action will change the action URL");
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
            sb.AppendLine("This Route was created by using the [HttpGet] Attribute");
            sb.AppendLine("One Parameter was defined in. Here's the C-tor description for it");
            sb.AppendLine("// Summary:");
            sb.AppendLine("//   Creates a new Microsoft.AspNetCore.Mvc.HttpGetAttribute with the given route");
            sb.AppendLine("//   template.");
            sb.AppendLine("//");
            sb.AppendLine("// Parameters:");
            sb.AppendLine("//   template: The route template. May not be null.");
            sb.AppendLine("public HttpGetAttribute(string template);");
            return Ok(sb.ToString());
        }

        [HttpPost, Route("TryToGetMeByPOST")]
        public IHttpActionResult RouteByPostAttr()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This Route was created by using the [HttpPost] Attribute");
            sb.AppendLine("The route was created the same way as the HttpGet Attribute");
            sb.AppendLine("This means... that all Http methods have this C-tor feature");
            return Ok(sb.ToString());
        }

        [HttpPut, Route("PutTheRoutePath")]
        public IHttpActionResult RouteByHeadAttr()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This Route was created by using the [HttpPut] Attribute");
            sb.AppendLine("Yup, this settles it, all Http method Attributes have this c-tor feature");
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
