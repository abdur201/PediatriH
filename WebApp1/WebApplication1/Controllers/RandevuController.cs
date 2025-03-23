using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using web.Models;

namespace WebApplication1.Controllers
{
    public class RandevuController : Controller
    {
        private readonly Context _context;

        public RandevuController(Context context)
        {
            _context = context;
        }

  
        public IActionResult Index()
        {
            var randevuList = _context.RandevuModels.ToList();
            return View("RandevuView",randevuList); 
        }

       
        public IActionResult Create()
        {
            return View();  
        }

    
        [HttpPost]
        
        public IActionResult Create(RandevuModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);  
                _context.SaveChanges(); 
                return RedirectToAction(nameof(Index)); 
            }
            return View(model);  
        }

    
        public IActionResult Edit(int id)
        {
            var randevu = _context.RandevuModels.FirstOrDefault(r => r.RandevuId == id);
            if (randevu == null)
            {
                return NotFound();  
            }
            return View(randevu); 
        }

       
        [HttpPost]
       
        public IActionResult Edit(int id, RandevuModel model)
        {
            if (id != model.RandevuId)
            {
                return NotFound(); 
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model); 
                    _context.SaveChanges(); 
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.RandevuModels.Any(r => r.RandevuId == id))
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
            return View(model);
        }

       
        public IActionResult Delete(int id)
        {
            var randevu = _context.RandevuModels.FirstOrDefault(r => r.RandevuId == id);
            if (randevu == null)
            {
                return NotFound(); 
            }
            return View(randevu); 
        }

        // POST: Randevu/Delete/5
        [HttpPost, ActionName("Delete")]
       
        public IActionResult DeleteConfirmed(int id)
        {
            var randevu = _context.RandevuModels.FirstOrDefault(r => r.RandevuId == id);
            if (randevu != null)
            {
                _context.RandevuModels.Remove(randevu);
                _context.SaveChanges(); 
            }
            return RedirectToAction(nameof(Index)); 
        }
    }
}


