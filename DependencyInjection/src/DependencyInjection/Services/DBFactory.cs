using DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class DBFactory : IDBFactory
    {
        public List<Product> _products = new List<Product>();
        public DBFactory()
        {
            _products.Add(new Product() { ProductID = 1, Name = "ABC1", Brand = "PPP1", NoofItems = 3, Quality = "AAA1" });
            _products.Add(new Product() { ProductID = 2, Name = "ABC2", Brand = "PPP2", NoofItems = 2, Quality = "AAA2" });
            _products.Add(new Product() { ProductID = 3, Name = "ABC3", Brand = "PPP3", NoofItems = 4, Quality = "AAA3" });
            _products.Add(new Product() { ProductID = 4, Name = "ABC4", Brand = "PPP4", NoofItems = 5, Quality = "AAA4" });
            _products.Add(new Product() { ProductID = 5, Name = "ABC5", Brand = "PPP5", NoofItems = 7, Quality = "AAA5" });
            _products.Add(new Product() { ProductID = 6, Name = "ABC6", Brand = "PPP6", NoofItems = 3, Quality = "AAA6" });
        }

        List<Product> IDBFactory.GetAllProducts()
        {
            return _products;
        }

        Product IDBFactory.GetProductbyID(int productID)
        {
            var prod = (from p in _products
                        where p.ProductID == productID
                        select p).FirstOrDefault();

            return prod;
        }
    }

    public interface IDBFactory
    {
        List<Product> GetAllProducts();
        Product GetProductbyID(int ProductID);
    }

}
