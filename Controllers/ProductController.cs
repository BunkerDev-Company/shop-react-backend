using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopBackend.Helpers;

namespace ShopBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("One")]
        public IActionResult GetOneProducts(int id)
        {
            var product = FakeDatabase._products.Where(x=>x.Id == id).FirstOrDefault();
            if (product == null)
            {
                return Ok("Товара нет");
            }
            return Ok(product);
        }

        [HttpGet("All")]
        public IActionResult GetAllProduct()
        {
            var listProducts = FakeDatabase._products.ToList();
            return Ok(listProducts);
        }
    }
}
