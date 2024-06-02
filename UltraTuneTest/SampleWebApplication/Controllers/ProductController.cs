using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SampleWebApplication.DependencyInjection;
using SampleWebApplication.Model;

//Question 3 : Create a simple ASP.NET Core Web API controller with endpoints to perform CRUD operations on a `Product` entity.
namespace SampleWebApplication.Controllers
{
    [ApiController]
    [Route("")]
    public class ProductController : Controller
    {
        private readonly IMessageService messageService;

        private static List<Product> products = new List<Product>()
        {
            new Product { Id = 1001, Name = "Product 1", Price = 100.00},
            new Product { Id = 1002, Name = "Product 2", Price = 103.50},
            new Product { Id = 1003, Name = "Product 3", Price = 110.00},
            new Product { Id = 1004, Name = "Product 4", Price = 210.99},
        };
        public ProductController(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        [HttpGet("/GetAllProducts")]
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        [HttpGet("/GetMessage/{text}")]
        public ActionResult GetMessage(string text)
        {
            var message = messageService.GetMessage(text);
            return Ok(message);
        }

        [HttpGet("/GetProductById/{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                return product;
            }
        }

        [HttpPost("/Create")]
        public ActionResult Create(Product product)
        {
            products.Add(product);
            return NoContent();
        }

        [HttpPut("/Update")]
        public ActionResult Put(int id, string name, double price)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            else
            {
                existingProduct.Name = name;
                existingProduct.Price = price;
                return NoContent();
            }
        }

        [HttpDelete("/Delete/{id}")]
        public ActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();
            else
            {
                products.Remove(product);
                return NoContent();
            }
        }
    }
}
