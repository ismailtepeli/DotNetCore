using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IT.MvcWebUI.Identity;
using IT.MvcWebUI.Models.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IT.MvcWebUI.Controllers
{
    public class SecurityController : Controller
    {
        private UserManager<AppIdentityUser> _userManager;

        private RoleManager<AppIdentityRole> _roleManager;

        private SignInManager<AppIdentityUser> _signInManager;

        public SecurityController(UserManager<AppIdentityUser> userManager, RoleManager<AppIdentityRole> roleManager, SignInManager<AppIdentityUser> signInManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViwModel loginViwModel, string returnUrl = "")
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(loginViwModel.Email);

                if (user != null)
                {
                    if (!await _userManager.IsEmailConfirmedAsync(user))
                    {
                        ModelState.AddModelError(string.Empty, "Mailinizi onaylayınız");
                        return View(loginViwModel);
                    }
                    var result = await _signInManager.PasswordSignInAsync(user, loginViwModel.Password, false, true);

                    if (result.Succeeded)
                    {
                        if (!String.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        {
                            return Redirect(returnUrl);
                        }
                        else
                        {
                            return View(loginViwModel);

                        }
                    }
                    ModelState.AddModelError(String.Empty, "Giriş Başarısız");
                    return View(loginViwModel);
                }
            }

            return View(loginViwModel);
        }
    }
}