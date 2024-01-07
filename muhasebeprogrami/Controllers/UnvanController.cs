using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using muhasebeprogrami.Data;
using muhasebeprogrami.Models;


namespace muhasebeprogrami.Controllers
{
    public class UnvanController : Controller
    {
        private readonly Context _context;
        // GET: UnvanController

        public UnvanController(Context context)
        {
            _context=context;
        }
        public ActionResult Index()
        {
            var listem = _context.unvans.ToList();
            return View(listem);
        }

        // GET: UnvanController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UnvanController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnvanController/Create
        [HttpPost]
       
        public ActionResult Create(Unvan gelen)
        {
            try
            {
                _context.unvans.Add(gelen);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UnvanController/Edit/5
        public ActionResult Edit(int id)
        {
            var bul = _context.unvans.Find(id);
            return View(bul);
        }

        // POST: UnvanController/Edit/5
        [HttpPost]
       
        public ActionResult Edit(Unvan gelen)
        {
            try
            {
                _context.unvans.Update(gelen);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UnvanController/Delete/5
        public ActionResult Delete(int id)
        {
            var bul = _context.unvans.Find(id);
            return View(bul);
        }

        // POST: UnvanController/Delete/5
        [HttpPost]
       
        public ActionResult Delete(Unvan gelen)
        {
            try
            {
                _context.unvans.Remove(gelen);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
