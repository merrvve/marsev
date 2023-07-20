using marsev.Context;
using marsev.Models;
using marsev.RepositoryPattern.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace marsev.Controllers
{
    public class FormController : Controller
    {
        public IRepository<FormModel> _repoFm;
        public FormController(IRepository<FormModel> fm) 
        {
            _repoFm = fm;
            
        }

        public IActionResult IletisimFormu()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormVerisiEkle(FormModel fvm)
        {
            _repoFm.Add(fvm);
            return RedirectToAction("Index","Home");
        }
    }
}
