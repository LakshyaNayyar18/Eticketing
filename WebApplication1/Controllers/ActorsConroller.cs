using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ActorsConroller : Controller
    {
        private readonly AppDbContext _context;
        public ActorsConroller(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View();
        }
    }
}
