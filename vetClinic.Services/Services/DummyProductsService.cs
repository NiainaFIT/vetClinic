using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vetClinic.Model;
using vetClinic.Services.Interfaces;

namespace vetClinic.Services.Services
{
    public class DummyProductsService
    {
        public DummyProductsService()
        {

        }
        public List<Product> ProductList = new List<Model.Product>() { new Model.Product() { ProductId = 1, ProductName = "Test1" }, new Model.Product() { ProductId = 2, ProductName = "Test2" } };
        public IEnumerable<Product> Get()
        {
            ProductList.Add(new Product { ProductId = -1, ProductName = "Test" });
            return ProductList;
        }
    }
}
