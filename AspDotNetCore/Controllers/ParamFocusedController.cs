using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetCore.Controllers
{
    [Route("api/[controller]/[Action]")] // Setting route here, is like setting the Route-prefix
    [ApiController]
    public class ParamFocusedController : ControllerBase
    {
        [Route("/Overridor")] // Overrides the prefix with '/'
        [Route("~/TildaOverridor")] // You can also use "~/"
        public IActionResult OverrideDefaultRoute()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Overrides the prefix with the char '/' at the START");
            sb.AppendLine("you can also use \" ~/ \"");
            return Ok(sb.ToString());
        }

        public IActionResult NoParam()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Just call and that's it 👍");
            sb.AppendLine("Note! the route is defined in the Ctrl.");
            return Ok(sb.ToString());
        }

        public IActionResult QueryString(int n, string s, bool b)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Getting parameters via query string.");
            sb.AppendLine("Parameters are primitive.");
            sb.AppendLine("Note! if you don't define one of them, they'll be set with their default value");
            sb.AppendLine();
            sb.AppendLine("Note! the boolean value can be set only by the string values of \"False\" \"True\"");
            sb.AppendLine("The string value is not case sensitive, e.g. \"fAlSe\". ");
            sb.AppendLine($"Number = {n}");
            sb.AppendLine($"String = {s}");
            sb.AppendLine($"Boolean = {b}");
            return Ok(sb.ToString());
        }

        [Route("{id}/{name}")]
        public IActionResult RouteParams(int id, string name)
        {
            StringBuilder sb = new StringBuilder("If route params are set like this, then they must be inserted in!");
            return Ok(sb.ToString());
        }

        [Route("/api/BoolRouteParam/{boolean}")]
        public IActionResult BoolRouteParam(bool boolean)
        {
            StringBuilder sb = new StringBuilder("Once again, boolean must be set via string of True and false");
            sb.AppendLine("The string value is not case sensitive, e.g. \"fAlSe\". ");
            return Ok(sb.ToString());
        }
    }
}
