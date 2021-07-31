using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.SessionState;

namespace AspDotNetFramework.Controllers
{
    [RoutePrefix("api")]
    public class CachingFocusedController : ApiController
    {
        private readonly HttpApplicationState _applicationState;
        private readonly HttpSessionState _session;

        public CachingFocusedController()
        {
            _applicationState = HttpContext.Current.Application;
            _session = HttpContext.Current.Session;
        }

        [HttpGet, Route("Cache/App/Add")]
        public IHttpActionResult AddValueToApplicationStage([FromUri] string val)
        {
            if (string.IsNullOrWhiteSpace(val))
            {
                return BadRequest("add query string value named \"val\", please");
            }
            else
            {
                string key = (_applicationState.Count + 1).ToString();
                _applicationState.Add(key, val);
                return Ok("Value saved");
            }
        }
        [HttpGet, Route("Cache/App")]
        public IHttpActionResult GetAppStateData()
        {
            if (_applicationState.Count <= 0) return Ok("It's empty, please add");
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (string key in _applicationState.Keys)
            {
                dict.Add(key, _applicationState[key].ToString());
            }
            return Ok(dict);
        }

        [HttpGet, Route("Cache/Session/Add")]
        public IHttpActionResult AddValueToSessionStage([FromUri] string val)
        {
            if (string.IsNullOrWhiteSpace(val))
            {
                return BadRequest("add query string value named \"val\", please");
            }
            else
            {
                string key = (_session.Count + 1).ToString();
                _session.Add(key, val);
                return Ok("Value saved");
            }
        }
        [HttpGet, Route("Cache/Session")]
        public IHttpActionResult GetSessionData()
        {
            if (_session.Count <= 0) return Ok("It's empty, please add");
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (string key in _session.Keys)
            {
                dict.Add(key, _session[key].ToString());
            }
            return Ok(dict);
        }
        //To add session,
        //visit this: https://stackoverflow.com/questions/9594229/accessing-session-using-asp-net-web-api
    }
}