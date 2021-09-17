using FiltersDemo.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace FiltersDemo.Controllers
{
    public class AuthFilterDemoController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Authorize("read")]
        public IActionResult Read()
        {
            return View();
        }
        [Authorize("write")]
        public IActionResult Write()
        {
            return View();
        }




    }
}
