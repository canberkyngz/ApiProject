using ApiDeneme.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiDeneme.Controllers
{
    // localhost:5000/api/products port örnek amaçlı
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        public static List<Product>? _products;

        public ProductController()
        {
            _products = new List<Product>
            {
               new Product { ProductId=1, ProductName = "Iphone 11", Price = 60000, IsActive = true},
               new Product { ProductId=2, ProductName = "Iphone 12", Price = 70000, IsActive = true},
               new Product { ProductId=3, ProductName = "Iphone 13", Price = 80000, IsActive = true},
               new Product { ProductId=4, ProductName = "Iphone 14", Price = 90000, IsActive = true},
               new Product { ProductId=5, ProductName = "Iphone 15", Price = 100000, IsActive = true}
            };

        }

        // localhost:5000/api/products => GET
        [HttpGet]
        public IActionResult GetProducts()
        {
            if (_products == null)
            {
                return NotFound();
            }

            return Ok(_products);
        }

        // localhost:5000/api/products/1 => GET
        [HttpGet("{id}")]
        public IActionResult GetProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var p =_products?.FirstOrDefault(i=>i.ProductId == id);
            if (p == null)
            {
                return NotFound();
            }
            return Ok(p);
        }

    }
}   
