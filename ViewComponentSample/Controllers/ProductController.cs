using Microsoft.AspNetCore.Mvc;

namespace ViewComponentSample.Controllers;
[ViewComponent(Name ="ProductSummary")]
public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public string Invoke() => "Product Summary";
}
