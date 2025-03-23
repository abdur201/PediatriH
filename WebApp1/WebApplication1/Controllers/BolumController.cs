using Microsoft.AspNetCore.Mvc;
using web.Models;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BolumController : Controller
    {
        private readonly Context _context;
        public BolumController(Context context)
        {
            _context = context;
        }

      
        public IActionResult Index()
        {
           
            var BolumList = _context.BolumModels.ToList();
            return View("BolumView", BolumList);  
        }





        public IActionResult Edit(int id)
        {
            var bolum = _context.BolumModels.Find(id);
            if (bolum == null)
            {
                return NotFound();
            }
            return View(bolum);
        }

        
        [HttpPost]
       
        public IActionResult Edit(int id, BolumModel bolum)
        {
            if (id != bolum.BolumId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(bolum);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(bolum);
        }

      

    }
}
