using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControlAltPC.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(string product)//asp-route-product
        {
            //store the selected product name in the view bag container
            //View bag is automatically passed back to the view that is loaded
            ViewBag.product = product;

            return View();
        }
    }
}