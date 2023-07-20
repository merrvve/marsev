using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using marsev.Models;
using System.Security.Cryptography.X509Certificates;
using marsev.Services;
using marsev.Context;
using Microsoft.EntityFrameworkCore;
using marsev.RepositoryPattern.Concrete;
using marsev.RepositoryPattern.interfaces;

namespace marsev.Controllers
{
    
    public class HomeController : Controller
    {
        
        IEtkinlikRepository _repoEtk;
        public HomeController(MMDbContext db, IEtkinlikRepository repoEtk)
        {

            _repoEtk = repoEtk;
        }

        public IActionResult Index()
        {
            List<Etkinlik> GecmisEtk = _repoEtk.EtkinlikAl("Gecmis");
            GecmisEtk = GecmisEtk.OrderByDescending(x => x.EtkinlikTarihi).ToList();
            List<Etkinlik> YaklasanEtk = _repoEtk.EtkinlikAl("Yaklasan");
            (List<Etkinlik>, List<Etkinlik>) tuple = (GecmisEtk, YaklasanEtk);
            return View(tuple);
        }

        public IActionResult Amaclar()
        {
            return View();
        }

        public IActionResult Kurul()
        {
            return View();
        }

        public IActionResult Bagis()
        {
            return View();
        }
        public IActionResult Kitap()
        {
            return View();
        }

        public IActionResult KitapSatis() 
        {
            return View();
        }
        public IActionResult Duyurular()
        {
            List<Etkinlik> GecmisEtk = _repoEtk.EtkinlikAl("Gecmis");
            GecmisEtk = GecmisEtk.OrderByDescending(x => x.EtkinlikTarihi).ToList();
            List<Etkinlik> YaklasanEtk = _repoEtk.EtkinlikAl("Yaklasan");
            (List<Etkinlik>, List<Etkinlik>) tuple = (GecmisEtk, YaklasanEtk);
            return View(tuple);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

      

        
        public IActionResult Kayit ()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Kayit(Kayit kayitim)
        {
            KayitService ks = new KayitService();
            ks.KayitEkle(kayitim); 
            return RedirectToAction("Index");
        }

    }
}