using BussinessObjects;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text.Json;

public class ProductController : Controller
{
    private readonly HttpClient client = null;
    private string ProductApiUrl = "";

    public ProductController()
    {
        client = new HttpClient();
        var contetType = new MediaTypeWithQualityHeaderValue("application/json");
        client.DefaultRequestHeaders.Accept.Add(contetType);
        ProductApiUrl = "https://localhost:7252/api/Products";
    }

    public async Task<IActionResult> Index()
    {
        HttpResponseMessage response = await client.GetAsync(ProductApiUrl);
        string data = await response.Content.ReadAsStringAsync();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        List<Product> products = new List<Product>();
        try
        {
            products = JsonSerializer.Deserialize<List<Product>>(data, options);
        } catch (Exception ex)
        {

        }

        return View(products);
    }

    public ActionResult Details(int Id)
    {
        return NoContent();
    }

    public ActionResult Create()
    {
        return NoContent();
    }

    public async Task<IActionResult> Create(Product p)
    {
        return NoContent();
    }

    public ActionResult Edit(int Id, IFormCollection collection)
    {
        return NoContent();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int Id, IFormCollection collection)
    {
        return NoContent();
    }
}
