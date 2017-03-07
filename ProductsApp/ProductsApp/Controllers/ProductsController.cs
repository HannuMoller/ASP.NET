using System.Linq;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
       {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M },
            new Product { Id = 4, Name = "Mushroom Soup", Category = "Groceries", Price = 2.50M },
            new Product { Id = 5, Name = "Picachu", Category = "Toys", Price = 333.85M },
            new Product { Id = 6, Name = "Scissors", Category = "Hardware", Price = 12.95M }
       };

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Product[] GetAllProducts()
        {
            return products;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
