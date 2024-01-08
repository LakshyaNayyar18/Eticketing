using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers.Data
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
