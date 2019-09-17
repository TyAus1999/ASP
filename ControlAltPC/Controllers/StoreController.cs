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
            //Make list of mock products
            var products = new List<Models.Product>();
            //use loop to populate product list
            for(int i = 0; i < 11; i++)
            {
                products.Add(new Models.Product { Name = "Product " + (i + 1).ToString()});
            }

            return View(products);
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