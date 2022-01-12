using Microsoft.AspNetCore.Mvc;
using Nordfin_AssignmentServices.Services.ProductServices;
using Nordfin_AssignmentShared.ResponseModels;

namespace Nordfin_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentException(nameof(productService));
        }

        [HttpGet]
        public ActionResult<List<ProductResponse>> GetAllProducts()
        {
            var productResponses = _productService.GetAllProducts();
            if (productResponses != null && productResponses.Count > 0)
            {
                return Ok(productResponses);
            }
            else
            {
                return BadRequest(productResponses);
            }
        }

    }
}
