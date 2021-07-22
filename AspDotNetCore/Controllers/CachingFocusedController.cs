using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AspDotNetCore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CachingFocusedController : ControllerBase
    {
        private readonly IMemoryCache _memoryCache;

        public CachingFocusedController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        private const string basicCachingExampleKey = "CachingFocusedController-BasicCachingExample";
        [HttpPost]
        public IActionResult BasicCachingExample([FromQuery] string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return BadRequest("You must supply a value");
            }
            else
            {
                _memoryCache.Set(basicCachingExampleKey, value, new MemoryCacheEntryOptions
                {
                    SlidingExpiration = TimeSpan.FromSeconds(20)
                });
                return StatusCode((int)HttpStatusCode.Accepted, "Value cached for 20 seconds (SlidingExpiration)");
            }
        }
        [HttpGet]
        public IActionResult BasicCachingExample()
        {
            string cachedValue;
            bool found = _memoryCache.TryGetValue(basicCachingExampleKey, out cachedValue);
            if (found) return Ok("Here's the cache value : " + cachedValue);
            else return NotFound("The caching either timed out, deleted or not set at all");
        }
        [HttpDelete]
        [Route("/api/[controller]/BasicCachingExample")]
        public IActionResult DeleteBasicCachingExample()
        {
            string cachedValue;
            bool found = _memoryCache.TryGetValue(basicCachingExampleKey, out cachedValue);
            if (found)
            {
                _memoryCache.Remove(basicCachingExampleKey);
                return Ok("Delete the cached value : " + cachedValue);
            }
            else return NotFound("The caching either timed out or not set at all");
        }
    }
}
