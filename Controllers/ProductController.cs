using LAB03.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LAB03.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop Dell", Price = 15999999.99M },
                new Product { Id = 2, Name = "MacBook Pro", Price = 24999999.99M },
                new Product { Id = 3, Name = "HP Spectre x360", Price = 18999999.99M },
                new Product { Id = 4, Name = "Lenovo ThinkPad", Price = 13999999.99M }
            };

            return View(products);
        }
    }
}


