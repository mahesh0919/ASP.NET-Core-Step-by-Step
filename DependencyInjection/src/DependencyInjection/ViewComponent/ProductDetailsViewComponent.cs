using Microsoft.AspNet.Mvc;
using DependencyInjection.Services;
using System.Collections.Generic;
using DependencyInjection.Models;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class ProductDetailsViewComponent : ViewComponent
    {
        private readonly IDBFactory _prodFactory;
        public ProductDetailsViewComponent(IDBFactory prodFactory)
        {
            _prodFactory = prodFactory;
        }

        public IViewComponentResult Invoke(int id)
        {
            List<Product> productList = _prodFactory.GetAllProducts();
            Product prod = (from p in productList
                            where p.ProductID == id
                            select p).FirstOrDefault();

            return View(prod);
        }
    }
}