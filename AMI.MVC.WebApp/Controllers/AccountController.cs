using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AMI.Business.UserLogic;
using AMI.Model;
using AMI.MVC.WebApp.Models.Account;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace AMI.MVC.WebApp.Controllers
{
    [Authorize]
    public partial class AccountController : Controller
    {
        #region Properties
        public IAuthenticationManager AuthenticationManager { get { return HttpContext.GetOwinContext().Authentication; } }
        #endregion

        [HttpGet]
        [AllowAnonymous]
        public virtual ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public virtual async Task<ActionResult> Login(LoginModel model)
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
        public virtual ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public virtual async Task<ActionResult> Register(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                //Create an application user.
                ApplicationUser user = new ApplicationUser
                {
                    CreatedOn = DateTime.Now,
                    Email = registerModel.EmailAddress,
                    IsActive = true,
                    UserName = registerModel.EmailAddress
                };

                var identityResult = await UserCommands.RegisterUser(user, registerModel.Password);
                if (identityResult.Succeeded)
                {
                    //Log them in.
                    var claimsIdentity = await UserCommands.SignIn(registerModel.EmailAddress, registerModel.Password);
                    if (claimsIdentity != null)
                    {
                        AuthenticationManager.SignIn(claimsIdentity);
                        return RedirectToAction("Index", "Home");
                    }

                    ModelState.AddModelError("", "MAJOR ERROR: UNABLE TO SIGN IN NEW REGISTER USER. WTF.");
                }
                else
                {
                    ModelState.AddModelError("", string.Join(", ", identityResult.Errors));
                }
            }
            //Here, means we're invalid, show the view again.
            return View();
        }

        [HttpGet]
        public virtual ActionResult Logout()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return View();
        }
	}
}