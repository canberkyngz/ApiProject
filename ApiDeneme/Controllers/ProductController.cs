using Microsoft.AspNetCore.Mvc;

namespace ApiDeneme.Controllers
{
    // localhost:5000/api/products port örnek amaçlı
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        public static readonly string[] Products = {
            "Iphone 11","Iphone 12","Iphone 13","Iphone 14","Iphone 15","Iphone 16"
        };

        // localhost:5000/api/products => GET
        [HttpGet]
        public string[] GetProducts()
        {
            return Products;
        }

        // localhost:5000/api/products/1 => GET
        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return Products[id];
        }

    }
}
