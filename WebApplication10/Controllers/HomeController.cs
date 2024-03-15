using Microsoft.AspNetCore.Mvc;
using WebApplication10.Data;

namespace WebApplication10.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
