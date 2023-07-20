using marsev.Context;
using marsev.Models;
using marsev.RepositoryPattern.interfaces;
using marsev.RepositoryPattern.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using marsev.RepositoryPattern.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace marsev.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class DashBoardController : Controller
    {
        
        IEtkinlikRepository _repoEtkinlik;
        IRepository<Kitap> _repoKitap;
        public DashBoardController(IEtkinlikRepository repoEtkinlik, 
            IRepository<Kitap> repoKitap) 
        {
           
            _repoEtkinlik = repoEtkinlik;
            _repoKitap = repoKitap;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EtkinlikListele()
        {
            List<Etkinlik> letk = _repoEtkinlik.GetAll();
            return View(letk);
        }

       
        [HttpPost]
        public IActionResult EtkinlikEkle(Etkinlik etk)
        {
            
            _repoEtkinlik.Add(etk);
            return RedirectToAction("EtkinlikListele", "DashBoard", new
            {
                area = "Management"
            });
        }

        public IActionResult EtkinlikEkle() {
            return View();
        }

        public IActionResult EtkinlikDuzenle(int Id)
        {
            Etkinlik etk = _repoEtkinlik.GetById(Id);
            return View(etk);
        }

        [HttpPost]

        public IActionResult EtkinlikDuzenle(Etkinlik etk)
        {
            _repoEtkinlik.Update(etk);
            return RedirectToAction("EtkinlikListele", "DashBoard", new
            {
                area = "Management"
            });
           
        }

        public IActionResult EtkinlikSil(int Id) {
            _repoEtkinlik.Delete(Id);
         
            return RedirectToAction("EtkinlikListele", "DashBoard", new { area = "Management" });
        }
        public IActionResult KitapListele()
        {
            List<Kitap> lkit = _repoKitap.GetAll();
            return View(lkit);
        }


        [HttpPost]
        public IActionResult KitapEkle(Kitap kit)
        {

            _repoKitap.Add(kit);
            return RedirectToAction("KitapListele", "DashBoard", new
            {
                area = "Management"
            });
        }

        public IActionResult KitapEkle()
        {
            return View();
        }

        public IActionResult KitapDuzenle(int Id)
        {
            Kitap kit = _repoKitap.GetById(Id);
            _repoKitap.Update(kit);
            return View(kit);
        }

        [HttpPost]

        public IActionResult KitapDuzenle(Kitap kit)
        {
            _repoKitap.Update(kit);
      
            return RedirectToAction("KitapListele", "DashBoard", new { area = "Management" });

        }

        public IActionResult KitapSil(int Id)
        {
            _repoKitap.Delete(Id);
            return RedirectToAction("KitapListele","DashBoard",new {area="Management"});
        }


    }
}
