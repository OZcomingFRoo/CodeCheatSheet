using AspDotNetCore.Pocos;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Newtonsoft.Json;

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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("If route params are set like this, then they must be inserted in!");
            sb.AppendLine($"1st route param, id = {id}");
            sb.AppendLine($"2nd route param, name = {name}");
            return Ok(sb.ToString());
        }

        [Route("/api/BoolRouteParam/{boolean}")]
        public IActionResult BoolRouteParam(bool boolean)
        {
            StringBuilder sb = new StringBuilder("Once again, boolean must be set via string of True and false");
            sb.AppendLine("The string value is not case sensitive, e.g. \"fAlSe\". ");
            return Ok(sb.ToString());
        }

        [Route("{id?}/{name?}")]
        public IActionResult DefaultRouteParams(int id = 100, string name = "Default String params")
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("We can define default values for route parameters by adding char '?' to the right side of the param");
            sb.AppendLine("Here's how the route params were define: {id?}/{name?}");
            sb.AppendLine("Note! if you define the param as optional, you must add the default value");
            sb.AppendLine($"1st route param, id = {id}. " +
                $"Is default ? {(id == 100).ToString()}");
            sb.AppendLine($"2nd route param, name = \"{name}\". " +
                $"Is default ? {(name == "Default String params").ToString()} ");
            return Ok(sb.ToString());
            // relevent link to this:
            // https://docs.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2#optional-uri-parameters-and-default-values
        }

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
