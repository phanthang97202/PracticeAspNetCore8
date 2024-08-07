using Microsoft.AspNetCore.Mvc;
using PracticeDI.Interfaces;
using PracticeDI.Models;

namespace PracticeDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {

            List<Product> products = _productRepository.GetAllProduct();
            return Ok(products);
        }
    }
}
