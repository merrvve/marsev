using marsev.Models;
using marsev.RepositoryPattern.interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace marsev.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]

    public class KursController : Controller
    {
        
        IRepository<Kayit> _repoKayit;
        public KursController(IRepository<Kayit> repoKayit)
        {
            _repoKayit = repoKayit;
        }

        public IActionResult KayitListele()
        {
            List<Kayit> lkayitlar=_repoKayit.GetAll();

            return View(lkayitlar);
        }

        public IActionResult KayitSil(int id)
        {
            _repoKayit.Delete(id);
            return RedirectToAction("KayitListele");
        }

        public IActionResult OdemeDuzenle(int id)
        {
            Kayit kt= _repoKayit.GetById(id);
            return View(kt);
        }

        [HttpPost]
        public IActionResult OdemeDuzenle(Kayit kt)
        {
            _repoKayit.Update(kt);
            return RedirectToAction("KayitListele", "Kurs", new { area = "Management" });
        }
    }
}
