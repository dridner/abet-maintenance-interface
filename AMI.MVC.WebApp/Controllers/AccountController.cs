using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AMI.Business.UserLogic;
using AMI.MVC.WebApp.Models.Account;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace AMI.MVC.WebApp.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        #region Properties
        public IAuthenticationManager AuthenticationManager { get { return HttpContext.GetOwinContext().Authentication; } }
        #endregion

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var claimsIdentity = await UserCommands.SignIn(model.Username, model.Password);
                if (claimsIdentity != null)
                {
                    AuthenticationManager.SignIn(new AuthenticationProperties { IsPersistent = model.RememberMe }, claimsIdentity);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid username or password!");
            }

            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Register()
        {

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(object registerModel)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await UserCommands.RegisterUser(null, null);
                if (identityResult.Succeeded)
                {
                    var claimsIdentity = await UserCommands.SignIn(null, null);
                    if (claimsIdentity != null)
                    {
                        AuthenticationManager.SignIn(properties: null, identities:claimsIdentity);
                    }
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return View();
        }
	}
}