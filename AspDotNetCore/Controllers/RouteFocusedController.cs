using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetCore.Controllers
{
    [ApiController]
    public class RouteFocusedController : ControllerBase
    {
        [Route("[controller]/[action]")]
        public IActionResult IamAnAction()
        {
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
        public IActionResult ConstUrl()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("You called this URL by typing the [domain name]/ConstUrlRoute.");
            sb.AppendLine("The route was defined in Action level");
            return Ok(sb.ToString());
        }

        [HttpGet("TryToGetMe", Name = "TryToGetMe Route Name")]
        public IActionResult RouteByGetAttr()
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
    }
}
