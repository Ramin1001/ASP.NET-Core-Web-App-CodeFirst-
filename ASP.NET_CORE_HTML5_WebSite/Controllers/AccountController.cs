using ASP.NET_CORE_HTML5_WebSite.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_HTML5_WebSite.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {

        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userMgr, SignInManager<IdentityUser> signinMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            return View(new LoginViewModel());
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                // Take user
                IdentityUser user = await userManager.FindByNameAsync(model.UserName);

                // Check user
                if (user != null)
                {
                    await signInManager.SignOutAsync(); // if true we sign out  and try enter with Password and give other property like remember me and so on
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false); // заблокировать при неудачном попытке входа
                    if (result.Succeeded) // if not return
                    {
                        return Redirect(returnUrl ?? "/");
                        // if successful, we send the user to the page where he tried to enter, otherwise to the main page
                    }
                }

                // if not in Db return back
                ModelState.AddModelError(nameof(LoginViewModel.UserName), "Wrong login or password");
            }

            return View(model);
        }


        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }




    }
}
