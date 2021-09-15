using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagement.Controllers
{
    public class QueryStringController : Controller
    {
        public IActionResult Index(string data)
        {
            return View("Index",data); 
        }
    }
}
