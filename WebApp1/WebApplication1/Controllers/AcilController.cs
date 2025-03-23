using Microsoft.AspNetCore.Mvc;
using web.Models;
using System.Linq;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    public class AcilController : Controller
    {
        private readonly Context _context;

       
        public AcilController(Context context)
        {
            _context = context;
        }

       
        public IActionResult Index()
        {
            
            var acilList = _context.AcilModels.ToList();
            return View("AcilView",acilList);  
        }




        public IActionResult Create()
        {
            return View();  
        }

      
        [HttpPost]
        
        public IActionResult Create(AcilModel model)
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
            var acil = _context.AcilModels.FirstOrDefault(a => a.AcilId == id); 
            if (acil == null)
            {
                return NotFound();  
            }
            return View(acil);  
        }

       
        [HttpPost]
     
        public IActionResult Edit(int id, AcilModel model)
        {
            if (id != model.AcilId)
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
                    if (!_context.AcilModels.Any(a => a.AcilId == id))
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
            var acil = _context.AcilModels.FirstOrDefault(a => a.AcilId == id); 
            if (acil == null)
            {
                return NotFound();  
            }
            return View(acil);  
        }

      
        [HttpPost, ActionName("Delete")]
   
        public IActionResult DeleteConfirmed(int id)
        {
            var acil = _context.AcilModels.FirstOrDefault(a => a.AcilId == id);  
            if (acil == null)
            {
                return NotFound();  
            }

            _context.AcilModels.Remove(acil);  
            _context.SaveChanges();  
            return RedirectToAction(nameof(Index));  
        }
    }






}

