using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Text;
using AspDotNetCore.Pocos;

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

        /// <summary>
        /// Memory Cache is using the applications memory to store values for caching.
        /// This is useful when you have 1 server up and running the application, for most occasions.
        /// When you a service (aka Redis) that is used for caching, or a Database, 
        /// you would most likely wanna use that (via "Distributed Cache") over the simplistic memory caching.
        /// </summary>
        #region Memory Caching example
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
        #endregion

        /// <summary>
        /// This should be used when you have more than one server up and running that serves the application, AKA, Load balancer.
        /// Caching data is saved outside of the application, thus carry their own advantages:
        /// - Is coherent (consistent) across requests to multiple servers.
        /// - Survives server restarts and app deployments.
        /// - Doesn't use local memory.
        /// </summary>
        #region Distributed Caching example
        private const string BASIC_DISTRIBUTED_CACHING_EXAMPLE_KEY = "CachingFocusedController-BasicDistributedCachingExample";
        [HttpPost]
        public async Task<IActionResult> BasicDistributedCachingExample([FromQuery] string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return BadRequest("You must supply a value");
            }
            else
            {
                byte[] valueByteArr = Encoding.UTF8.GetBytes(value);
                await _distributedCache.SetAsync(BASIC_MEMORY_CACHING_EXAMPLE_KEY, valueByteArr, new DistributedCacheEntryOptions
                {
                    SlidingExpiration = TimeSpan.FromSeconds(20)
                });
                return StatusCode((int)HttpStatusCode.Accepted, "Value cached for 20 seconds (SlidingExpiration)");
            }
        }
        [HttpGet]
        public async Task<IActionResult> BasicDistributedCachingExample()
        {
            string cachedStringValue = await _distributedCache.GetStringAsync(BASIC_MEMORY_CACHING_EXAMPLE_KEY);
            bool found = string.IsNullOrWhiteSpace(cachedStringValue) == false;
            if (found) return Ok("Here's the cache value : " + cachedStringValue);
            else return NotFound("The caching either timed out, deleted or not set at all");
        }
        [HttpDelete]
        [Route("/api/[controller]/BasicDistributedCachingExample")]
        public async Task<IActionResult> DeleteDistributedMemoryCachingExample()
        {
            string cachedStringValue = await _distributedCache.GetStringAsync(BASIC_MEMORY_CACHING_EXAMPLE_KEY);
            bool found = string.IsNullOrWhiteSpace(cachedStringValue) == false;
            if (found)
            {
                await _distributedCache.RemoveAsync(BASIC_MEMORY_CACHING_EXAMPLE_KEY);
                return Ok("Delete the cached value : " + cachedStringValue);
            }
            else return NotFound("The caching either timed out or not set at all");
        }
        #endregion

        /// <summary>
        /// This is NOT the session Id !
        /// </summary>
        private const string SESSION_KEY_VALUE = "session_key_value";
        [HttpPost]
        public IActionResult AddSessionVal([FromQuery] string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return BadRequest("Set query key & value");
            HttpContext.Session.SetString(SESSION_KEY_VALUE, value);
            return Ok("Save in session");
        }
        [HttpGet]
        public IActionResult GetSessionData()
        {
            var value = HttpContext.Session.GetString(SESSION_KEY_VALUE);
            bool found = string.IsNullOrWhiteSpace(value) == false;
            if (found) return Ok(value);
            else return NotFound("Session cookie is not valid or value was not posted");
        }
        [HttpGet, Route("/SessionExamplePage")]
        public async Task<IActionResult> SessionExamplePage()
        {
            var dir = System.IO.Directory.GetCurrentDirectory();
            string htmlPage = await System.IO.
                File.ReadAllTextAsync(System.IO.Path.Combine(dir, "SessionExamplePage", "Index.html"));
            return new ContentResult
            {
                ContentType = "text/html",
                Content = htmlPage
            };
        }
    }
}
