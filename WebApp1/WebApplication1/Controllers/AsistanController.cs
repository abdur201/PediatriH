using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web.Models;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AsistanController : Controller
    {
        private readonly Context _context;
        public AsistanController(Context context)
        {
            _context = context;
        }

     
        public IActionResult Index()
        {
          
            var asistanList = _context.AsistanModels.ToList();
            return View("AsistanView", asistanList); 
        }

        public IActionResult Edit(int id)
        {
            var asistan = _context.AsistanModels.FirstOrDefault(a => a.AsistanId == id);
            if (asistan == null)
            {
                return NotFound();
            }
            return View(asistan); 
        }

        
        [HttpPost]
        
        public IActionResult Edit(int id, AsistanModel asistan)
        {
            if (id != asistan.AsistanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(asistan);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.AsistanModels.Any(a => a.AsistanId == id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index)); 
            }
            return View(asistan);  
        }

    }
}
