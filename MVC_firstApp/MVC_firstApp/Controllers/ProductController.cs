using System;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using MVC_firstApp.Model;

namespace MVC_firstApp.Controllers
{
    public class ProductController : Controller
    {
        private List<Products> _products;
        public ProductController()
        {
            _products = new List<Products> { new Products { Id = 1, Name = "Iphone",Price=2500 }, new Products { Id = 2, Name = "Samsung",Price=2000 }, new Products { Id = 3, Name = "Xiomi", Price = 1000 }, new Products { Id = 4, Name = "Hower", Price = 1500 }, new Products { Id = 5, Name = "Macos", Price = 3600 } };
        }
        public JsonResult Get(int id, string name)
        {
            var data = _products[0];

            return Json(data);
        }

        public JsonResult GetAll()
        {
            return new JsonResult(_products);
        }

        public ViewResult Index()
        {
            ViewBag.Products = _products;

            return View("index");
        }

    }
}

