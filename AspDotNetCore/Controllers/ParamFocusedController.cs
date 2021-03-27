using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetCore.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class ParamFocusedController : ControllerBase
    {
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
    }
}
