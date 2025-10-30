using Microsoft.AspNetCore.Mvc;

namespace WebApplication7.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
