using Microsoft.AspNetCore.Mvc;
using muhasebeprogrami.Models;

namespace muhasebeprogrami.Controllers
{
    public class SehirController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Sehir gelen) {

            return View();
        }
    }
}
