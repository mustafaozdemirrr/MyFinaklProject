using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {
            _productService.Add(product);
            return Ok(product);
        }
        [HttpPost]
        public IActionResult Update([FromBody] Product product)
        {
            _productService.Update(product);
            return Ok(product);
        }
        [HttpPost]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _productService.Delete(id);
            return Ok();
        }
    }
}
