using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Gorev4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> _products;
        private static int _index;

        static ProductController()
        {
            //fake data
            _products = new List<Product>()
            {
                new Product { Id = 1, Name = "Stan Smith", Category = "Shoes", Price = 150 },
                new Product { Id = 2, Name = "Air Jordan", Category = "Shoes", Price = 180 },
                new Product { Id = 3, Name = "CrocBand", Category = "Slippers", Price = 50 },
                new Product { Id = 4, Name = "Dr. Martens", Category = "Boats", Price = 220 }
            };
            _index = _products.Count + 1;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            if (_products == null)
                return NotFound("Products not found!");

            return Ok(_products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct([FromRoute] int id)
        {
            var product = _products.Find(x => x.Id == id);

            if (product == null)
            {
                return BadRequest("No product was found with this id!");
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            product.Id = _index;
            _index++;
            _products.Add(product);
            return Ok(product);
        }

        [HttpPut]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            var index = _products.FindIndex(i => i.Id == product.Id);
            if (index == -1)
            {
                return BadRequest("No product was found with this id!");
            }
            _products[index].Name = product.Name;
            _products[index].Price = product.Price;
            _products[index].Category = product.Category;

            return Ok("Product Updated.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct([FromRoute] int id)
        {
            var index = _products.FindIndex(x => x.Id == id);
            if (index == -1)
            {
                return BadRequest("No product was found with this id!");
            }
            _products.RemoveAt(index);
            return Ok("User Deleted");
        }
    }
}
