using FiltersDemo.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace FiltersDemo.Controllers
{
    public class ValidateModelController : Controller
    {
        [ValidateModel]
        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }
    }
}
