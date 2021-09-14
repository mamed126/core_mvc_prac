using Microsoft.AspNetCore.Mvc;
using TruckSale2.Models;

namespace TruckSale2.Controllers
{
    public class TrucksController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Truck t)
        {
            if (ModelState.IsValid)
            {
                //do work
                return RedirectToAction("Index");
            }
            return View(t);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            Truck t = new Truck()
            {
                Brand = "Man",
                Distributors = new System.Collections.Generic.List<string> { "Dist1", "Dist2" },
                Id=1,
                Model="TGA 450",
                Price=150000,
                RegisterDate=new System.DateTime(2021,1,1)
            };

            return View(t);
        }
    }
}
