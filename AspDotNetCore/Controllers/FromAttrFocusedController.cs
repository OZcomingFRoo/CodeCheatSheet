using AspDotNetCore.Pocos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetCore.Controllers
{
    [Route("api/From/[action]")]
    [ApiController]
    public class FromAttrFocusedController : ControllerBase
    {
        public IActionResult SomeDataQuery([FromQuery] SomeData data)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Poco parameter was define like this : [FromQuery] SomeData data");
            sb.AppendLine("If a property was not set then default value will be inserted.");
            sb.AppendLine("Result as Json:");
            sb.AppendLine(JsonConvert.SerializeObject(data, Formatting.Indented));
            return Ok(sb);
        }
    }
}
