using Microsoft.AspNetCore.Mvc;
using muhasebeprogrami.Data;
using muhasebeprogrami.Models;

namespace muhasebeprogrami.Controllers
{
    public class SehirController : Controller
    {
        private readonly Context _context;

        public SehirController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var liste=_context.sehirs.ToList();
            return View(liste);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Sehir gelen) {
            _context.sehirs.Add(gelen);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet] 
        public IActionResult Edit(int id)
        {
            var bul = _context.sehirs.Find(id);
            return View(bul);
        }
        [HttpPost]
        public IActionResult Edit(Sehir gelen)
        {
            _context.sehirs.Update(gelen);
            _context.SaveChanges();
             return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var bul = _context.sehirs.Find(id);
            return View(bul);
        }
        [HttpPost]
        public IActionResult Delete(Sehir gelen)
        {
            _context.sehirs.Remove(gelen);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
