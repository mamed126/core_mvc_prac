using FiltersDemo.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace FiltersDemo.Controllers
{
    public class ResultFilterController : Controller
    {
        [AddHeader]
        public IActionResult Index()
        {
            return View();
        }
    }
}
