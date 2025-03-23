using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

using System.Linq;

namespace WebApplication1.Controllers
{
    public class GirisController : Controller
    {
        private readonly Context _context;

        public GirisController(Context context)
        {
            _context = context;
        }

      
        public IActionResult Index()
        {
            return View("GirisView"); 
        }

       
        [HttpGet]
        public IActionResult Login()
        {
            return View(); 
        }

        [HttpPost]
        
        public IActionResult Login(GirisModel model)
        {
            if (ModelState.IsValid)
            {
                
                var user = _context.GirisModels
                                .FirstOrDefault(u => u.FullName == model.FullName && u.Password == model.Password);

                if (user != null)
                {
                   
                    if (user.Role == 1)
                    {
                        
                        return RedirectToAction("Index", "Home");
                    }
                    else if (user.Role == 0)
                    {
                       
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                      
                        return RedirectToAction("Login", "Giris");
                    }
                }
                else
                {
                   
                    ViewBag.ErrorMessage = "Kullanıcı adı veya şifre hatalı!";
                    return View(); 
                }
            }

           
            return View();
        }
    }
}
