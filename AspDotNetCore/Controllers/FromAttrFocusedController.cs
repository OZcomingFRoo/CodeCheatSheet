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
        [HttpGet]
        public IActionResult SomeDataQuery([FromQuery] SomeData data)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Poco parameter was define like this : [FromQuery] SomeData data");
            sb.AppendLine("If a property was not set, then default value will be inserted.");
            sb.AppendLine("Example of how to send such data in a query string of the URL: ");
            sb.AppendLine("?NumProp=1&StrProp=asd&BoolProp=True");
            sb.AppendLine();
            sb.AppendLine("Result as Json:");
            sb.AppendLine(JsonConvert.SerializeObject(data, Formatting.Indented));
            return Ok(sb.ToString());
        }

        [HttpPost]
        public IActionResult TypicalPost([FromBody] SomeData data)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Thanks for the POST");
            sb.AppendLine("This is the most simple way to send data to a server, i.e. \"[FromBody] SomeData data\" ");
            sb.AppendLine("It's also the easiest one to use since we can define complex request data");
            sb.AppendLine("For an example, an request which contains a customer info in object 1, " +
                "and define his order details in object two");
            sb.AppendLine("It is very common to see an action defined with a POST method define to it");
            return Accepted(new SomeData { StrProp = sb.ToString(), NumProp = 1, BoolProp = true }); ;
        }
    }
}
