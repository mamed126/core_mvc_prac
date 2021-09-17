using Microsoft.AspNetCore.Mvc;
using System;

namespace FiltersDemo.Controllers
{
    public class ExceptionFilterController : Controller
    {
        public IActionResult GetError()
        {
            throw new NotImplementedException();
        }
    }
}
