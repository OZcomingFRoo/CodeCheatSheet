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
    public class DotNetCore : ControllerBase
    {
        [HttpGet]
        [Route("[controller]/[action]")]
        public IActionResult IamAnAction()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The route set on this Action was defined by the keywords:");
            sb.AppendLine("[controller] and [action]");
            sb.AppendLine("[controller] = \"DotNetCore\"");
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
    }
}
