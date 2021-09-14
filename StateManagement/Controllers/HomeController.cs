using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StateManagement.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string cookieName = "data";


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult RemoveCookie()
        {
            Response.Cookies.Delete(cookieName);
            return View(nameof(CookieIndex));
        }
        public IActionResult CookieIndex()
        {
            string data = Request.Cookies[cookieName];
            return View("CookieIndex", data);
        }
        [HttpPost]
        public IActionResult CookieIndex(IFormCollection f)
        {
            string data = f["form_data"].ToString();
            CookieOptions options = new CookieOptions { Expires = DateTime.Now.AddMinutes(10) };
            Response.Cookies.Append(cookieName, data, options);

            return RedirectToAction(nameof(CookieIndex));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
