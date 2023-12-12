using BussinessObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository repo = new ProductRepository();

        public ProductController()
        {
 
        }
        [HttpGet("id")]
        public ActionResult<Product> Get(int id) => repo.GetProductById(id);

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts() => repo.GetProducts();
        [HttpPost]
        public IActionResult PostProduct(Product p)
        {
            try
            {
                repo.SaveProduct(p);

                return CreatedAtAction(nameof(Get), new { id = p.ProductId }, p);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
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
        [HttpGet("startPrice/endPrice")]
        public IActionResult GetProduct(decimal startPrice, decimal endPrice)
        {
            if (startPrice > endPrice)
            {
                return BadRequest();
            }

            var products = new List<Product>();
            try
            {
                products = repo.GetProducts(startPrice, endPrice);
            }
            catch (Exception ex)
            {

            }

            if (products.Count > 0)
            {
                //return Ok(products.Select(mapper.Map<Product, ProductDAO>).ToList());
                return Ok(products.Select(p => new {
                    p.ProductId,
                    p.ProductName,
                    p.UnitsInStock,
                    p.UnitPrice,
                    p.CategoryId,
                    repo.GetCategories().FirstOrDefault(c => c.CategoryId == p.CategoryId).CategoryName
                }).ToList());
            }

            return NotFound();
        }

        [HttpDelete("delete-list-product")]
        public IActionResult DeleteProducts(int[] ids)
        {
            var products = repo.GetProducts(ids);

            if (products.Count > 0)
            {
                repo.DeleteProducts(products.ToArray());
                return Ok();
            }

            return BadRequest();
        }
    }
}
