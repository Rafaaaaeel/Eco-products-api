

namespace Eco.Products.Controllers;

[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[ApiController]
public class ProductController : ControllerBase 
{
   private IProductsRepository _repository;

   public ProductController(IProductsRepository repository) 
   {
        _repository = repository;
   } 

   [HttpGet]
   public ActionResult<ProductsResponse> GetProducts() 
   {
        ProductsResponse response = _repository.GetProducts();

        return Ok(response);
   }

}