using FiltersDemo.Attributes;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FiltersDemo.Controllers
{
    [CacheResource]
    public class ResFilterController : Controller
    {
        public IActionResult Index()
        {
            return Content("this is content, content generated time:" + DateTime.Now);
        }
    }
}
