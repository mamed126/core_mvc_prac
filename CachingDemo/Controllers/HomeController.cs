using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CachingDemo.Controllers
{
    [Route("Home/Index")]
    public class HomeController : Controller
    {
        private IMemoryCache _cache;

        public HomeController(IMemoryCache cache)
        {
            _cache = cache;
        }

        public IActionResult Index()
        {
            DateTime time;
            bool dataCached = _cache.TryGetValue("time", out time);
            if (!dataCached)
            {
                time = DateTime.Now;

                MemoryCacheEntryOptions options =
                    new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(20));

                _cache.Set("time", time, options);

            }
            return View(time);
        }
    }
}
