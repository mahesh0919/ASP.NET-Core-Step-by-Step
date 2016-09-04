using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DependencyInjection.Services;
using DependencyInjection.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDBFactory _prodFactory;
        public HomeController(IDBFactory prodFactory)
        {
            _prodFactory = prodFactory;
        }

        public IActionResult Index()
        {
            List<Product> productList = _prodFactory.GetAllProducts();

            return View(productList);
        }
    }
}
