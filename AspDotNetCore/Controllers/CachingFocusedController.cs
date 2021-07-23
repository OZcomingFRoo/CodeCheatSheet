using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Caching.Distributed;
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
        private readonly IDistributedCache _distributedCache;
        public CachingFocusedController(IMemoryCache memoryCache, IDistributedCache distributedCache)
        {
            _memoryCache = memoryCache;
            _distributedCache = distributedCache;
        }

        private const string BASIC_MEMORY_CACHING_EXAMPLE_KEY = "CachingFocusedController-BasicMemoryCachingExample";
        [HttpPost]
        public IActionResult BasicMemoryCachingExample([FromQuery] string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return BadRequest("You must supply a value");
            }
            else
            {
                _memoryCache.Set(BASIC_MEMORY_CACHING_EXAMPLE_KEY, value, new MemoryCacheEntryOptions
                {
                    SlidingExpiration = TimeSpan.FromSeconds(20)
                });
                return StatusCode((int)HttpStatusCode.Accepted, "Value cached for 20 seconds (SlidingExpiration)");
            }
        }
        [HttpGet]
        public IActionResult BasicMemoryCachingExample()
        {
            string cachedValue;
            bool found = _memoryCache.TryGetValue(BASIC_MEMORY_CACHING_EXAMPLE_KEY, out cachedValue);
            if (found) return Ok("Here's the cache value : " + cachedValue);
            else return NotFound("The caching either timed out, deleted or not set at all");
        }
        [HttpDelete]
        [Route("/api/[controller]/BasicMemoryCachingExample")]
        public IActionResult DeleteBasicMemoryCachingExample()
        {
            string cachedValue;
            bool found = _memoryCache.TryGetValue(BASIC_MEMORY_CACHING_EXAMPLE_KEY, out cachedValue);
            if (found)
            {
                _memoryCache.Remove(BASIC_MEMORY_CACHING_EXAMPLE_KEY);
                return Ok("Delete the cached value : " + cachedValue);
            }
            else return NotFound("The caching either timed out or not set at all");
        }
    }
}
