using marsev.Models;
using marsev.RepositoryPattern.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace marsev.Controllers
{
    public class KayitController : Controller
    {
        IRepository<Kayit> _repoKayit;

        public KayitController(IRepository<Kayit> repoKayit)
        {
            _repoKayit = repoKayit;
        }

        public IActionResult Kayit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kayit(Kayit kt)
        {
            _repoKayit.Add(kt);
            return RedirectToAction("Onay", "Kayit");
        }
        public IActionResult Onay()
        {
            return View();
        }

    }

}
