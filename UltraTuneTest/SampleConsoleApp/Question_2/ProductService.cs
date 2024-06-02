using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp.Question_2
{
    public class ProductService
    {
        private readonly IRepository<Product> repository;

        public ProductService()
        {
            repository = new Repository<Product>();
        }

        public List<Product> GetProducts()
        {
            return repository.GetAll();
        }

        public void AddProducts(List<Product> products)
        {
            repository.AddItems(products);
        }
    }
}
