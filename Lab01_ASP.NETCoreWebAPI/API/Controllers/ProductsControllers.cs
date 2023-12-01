using BussinessObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsControllers : ControllerBase
    {
        private IProductRepository repo = new ProductRepository();
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts() => repo.GetProducts();
        [HttpPost]
        public IActionResult PostProduct(Product p)
        {
            repo.SaveProduct(p);
            return NoContent();
        }
        [HttpDelete("Id")]
        public IActionResult DeleteProduct(int Id)
        {
            var p = repo.GetProductById(Id);
            if (p == null) return NoContent();
            repo.DeleteProduct(p);
            return NoContent();
        }

        [HttpPut("Id")]
        public IActionResult UpdateProduct(int Id, Product p)
        {
            var pTmp = repo.GetProductById(Id);
            if (pTmp == null) return NoContent();
            repo.UpdateProduct(p);
            return NoContent();
        }
    }
}
