using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var indexList = _context.IndexModels
                                   .OrderByDescending(n => n.Date)  
                                   .ToList();  
            return View("Index", indexList);  
        }
  


    }
}
