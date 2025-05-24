using Api_test_code.Data;
using Api_test_code.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_test_code.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public ActionResult<IEnumerator<Product>> GetProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }
    }
}
