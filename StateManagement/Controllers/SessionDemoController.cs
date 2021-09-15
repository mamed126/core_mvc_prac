using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagement.Controllers
{
    public class SessionDemoController : Controller
    {
        private string _sessionKey = "name";
        public IActionResult Index()
        {
           var data= HttpContext.Session.GetString(_sessionKey);

            return View(nameof(Index),data);
        }
        [HttpPost]
        public IActionResult Index(IFormCollection fc)
        {
            var data = fc["form_data"].ToString();
            HttpContext.Session.SetString(_sessionKey, data);
            return RedirectToAction(nameof(Index));
        }
        
        public IActionResult RemoveSession()
        {
            HttpContext.Session.Clear();
            return View(nameof(Index));
        }
    }
}
