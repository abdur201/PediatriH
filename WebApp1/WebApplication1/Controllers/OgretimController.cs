using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web.Models;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OgretimController : Controller
    {
        private readonly Context _context;
        public OgretimController(Context context)
        {
            _context = context;
        }

       
        public IActionResult Index()
        {
          
            var ogretimList = _context.OgretimModels.ToList();
            return View("OgretimView", ogretimList);  
        }

      
            
            
            public IActionResult Edit(int id)
            {
                var ogretim = _context.OgretimModels.Find(id);
                if (ogretim == null)
                {
                    return NotFound();
                }
                return View(ogretim); 
            }

            
            [HttpPost]
          
            public IActionResult Edit(int id, OgretimModel ogretim)
            {
                if (id != ogretim.OgretimId)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(ogretim);
                        _context.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!_context.OgretimModels.Any(e => e.OgretimId == id))
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
                return View(ogretim);  
            }
        


    }

}
