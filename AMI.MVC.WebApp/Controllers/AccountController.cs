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
                AuthenticationManager.SignIn(new AuthenticationProperties { IsPersistent = model.RememberMe }, claimsIdentity);
                return RedirectToAction("Index", "Home");
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