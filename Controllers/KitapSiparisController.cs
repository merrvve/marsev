using marsev.Models;
using marsev.RepositoryPattern.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace marsev.Controllers
{
    public class KitapSiparisController : Controller
    {
        public IRepository<KitapTalepModel> _repoKtm;
        public KitapSiparisController(IRepository<KitapTalepModel> ktm)
        {
            _repoKtm = ktm;

        }

        public IActionResult KitapSiparisi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KitapSiparisEkle(KitapTalepModel ktm)
        {
            _repoKtm.Add(ktm);
            return RedirectToAction("Index","Home");
        }
      
    }
}
