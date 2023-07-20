using BCrypt.Net;
using marsev.Models;
using marsev.RepositoryPattern.interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace marsev.Controllers
{
    
    public class AuthController : Controller
    {
        IRepository<AppUser> _repoUser;
        public AuthController(IRepository<AppUser> repouser)
        {
            _repoUser = repouser;
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]

        public async Task<IActionResult> Login(AppUser appUser)
        {
            if(!ModelState.IsValid)
            {
                return View(appUser);
            }
            if (_repoUser.Any(x => x.UserName == appUser.UserName))
            {
                AppUser selectedUser = _repoUser.Default(x => x.UserName == appUser.UserName);
                bool isValid = BCrypt.Net.BCrypt.Verify(appUser.Password, selectedUser.Password);
                if (isValid)
                {
                    List<Claim> claims = new List<Claim>
                    {
                        new Claim ("userName",selectedUser.UserName),
                        new Claim ("userId",selectedUser.Id.ToString()),
                        new Claim ("role",selectedUser.Role.ToString())
                    };
                    ClaimsIdentity identity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);
                    if (selectedUser.Role == Enums.Role.admin)
                    {
                        return RedirectToAction("EtkinlikListele", "DashBoard", new { area = "Management" });
                    }
                    else if (selectedUser.Role == Enums.Role.user)
                    {

                        return RedirectToAction("Index", "Home");
                    }
                }
            }


            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
