using marsev.Models;
using marsev.RepositoryPattern.interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace marsev.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class IletisimController : Controller
    {
        IRepository<FormModel> _repoForm;
        public IletisimController(IRepository<FormModel> Form)
        {
            _repoForm= Form;
        }

        public IActionResult FormListele()
        {
            List<FormModel> lfm = _repoForm.GetAll();
            return View(lfm);
        }

        public IActionResult FormSil(int id)
        {
            _repoForm.Delete(id);
            return RedirectToAction("FormListele");
        }
      
    }
}
