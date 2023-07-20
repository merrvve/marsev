using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using marsev.RepositoryPattern.interfaces;
using marsev.Models;

namespace marsev.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class KitapController : Controller
    {
        IRepository<KitapTalepModel> _ktm;
        public KitapController(IRepository<KitapTalepModel> ktm)
        {
            _ktm = ktm;
        }

        public IActionResult KitapSiparisListele()
        {
            List<KitapTalepModel> siparisler = _ktm.GetAll();
            return View(siparisler);
        }

        public IActionResult SiparisSil(int id)
        {
            _ktm.Delete(id);
            return RedirectToAction("KitapSiparisListele");
        }
    }
}
