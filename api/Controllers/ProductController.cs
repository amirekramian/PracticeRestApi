using Application.Interfaces;
using Infrastructure.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public  ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult>  Get(int Id)
        {
            var result = await productService.getById(Id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var result = await productService.getAll(); 
            return Ok(result);  
        }
        [HttpPost]
        public async Task<IActionResult> create(ProductDto model)
        {
            var result = await productService.Add(model);
            return Ok(result);
        }
    }
}
