using Microsoft.AspNetCore.Mvc;
using System.Text;

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

        [HttpPost("TryToGetMeByPOST")]
        public IActionResult RouteByPostAttr()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This Route was created by using the [HttpPost] Attribute");
            sb.AppendLine("The route was created the same way as the HttpGet Attribute");
            sb.AppendLine("This means... that all Http methods have this C-tor feature");
            return Ok(sb.ToString());
        }

        [HttpPut("PutTheRoutePath")]
        public IActionResult RouteByHeadAttr()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This Route was created by using the [HttpPut] Attribute");
            sb.AppendLine("Yup, this settles it, all Http method Attributes have this c-tor feature");
            return Ok(sb.ToString());
        }

        [Route("NoHttpMethodAttr")]
        public IActionResult NoMethodAttrRoute()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("if no Http Method Attribute was set, then all Http methods are valid");
            sb.AppendLine("as long as the route path is set.");
            sb.AppendLine("Try to call it with the most un-common Http methods and see that it still being called.");
            return Ok(sb.ToString());
        }
    }
}
