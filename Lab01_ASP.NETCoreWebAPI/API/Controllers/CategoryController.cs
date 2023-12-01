using BussinessObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/Category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository repo = new CategoryRepository();
        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            var categories = repo.GetCategories();
            return Ok(categories);
        }
    }
}
