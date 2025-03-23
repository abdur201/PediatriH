
using Microsoft.AspNetCore.Mvc;
using web.Models; 
using System.Linq; 
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models; 

namespace WebApplication1.Controllers
{
    public class NobetController : Controller
    {
        private readonly Context _context;

        public IActionResult GetAsistan(int asistanId)
        {
            
            var asistan = _context.AsistanModels.FirstOrDefault(a => a.AsistanId == asistanId);

            if (asistan == null)
            {
                
                return NotFound();
            }

           
            return View(asistan);
        }



        public NobetController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var nobetList = _context.NobetModels.ToList();
            return View("NobetView", nobetList);
        }



        [HttpGet]

        public IActionResult Delete(int id)
        {
            var nobet = _context.NobetModels.FirstOrDefault(n => n.NobetId == id); 
            if (nobet == null)
            {
                return NotFound(); 
            }
            return View(nobet); 
        }

        [HttpPost, ActionName("Delete")]
    
        public IActionResult DeleteConfirmed(int id)
        {
            var nobet = _context.NobetModels.FirstOrDefault(n => n.NobetId == id); // Silinecek kaydı al
            if (nobet == null)
            {
                return NotFound(); // Kaydı bulamazsanız 404 döndür
            }

            _context.NobetModels.Remove(nobet); // Kaydı sil
            _context.SaveChanges(); // Veritabanına kaydet
            return RedirectToAction(nameof(Index)); // Silme işlemi sonrası listeye yönlendir
        }

        public IActionResult Edit(int id)
        {
            var nobet = _context.NobetModels.FirstOrDefault(n => n.NobetId == id);
            if (nobet == null)
            {
                return NotFound();
            }
            return View(nobet); 
        }

       
        [HttpPost]
        
        public IActionResult Edit(int id, NobetModel model)
        {
            if (id != model.NobetId)
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
                    if (!_context.NobetModels.Any(n => n.NobetId == id))
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
    

  
    public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        
        public IActionResult Create(NobetModel model)
        {
            if (ModelState.IsValid)
            {
                _context.NobetModels.Add(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

    }
}
