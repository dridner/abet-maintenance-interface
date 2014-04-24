using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AMI.Business.Logic.UserLogic;
using AMI.Model;
using AMI.MVC.WebApp.Models.Account;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace AMI.MVC.WebApp.Controllers
{
    [Authorize]
    public partial class AccountController : Controller
    {
        private IsUserAllowedToRegisterCommand.Factory _isAllowedToRegisterCommand;
        private SendEmailForRegisteringUserCommand.Factory _sendEmailForRegisteringUserCommand;

        #region Properties
        public IAuthenticationManager AuthenticationManager { get { return HttpContext.GetOwinContext().Authentication; } }
        #endregion

        public AccountController(IsUserAllowedToRegisterCommand.Factory isAllowedToRegisterCommand, SendEmailForRegisteringUserCommand.Factory sendEmailForRegisteringUserCommand)
        {
            this._isAllowedToRegisterCommand = isAllowedToRegisterCommand;
            this._sendEmailForRegisteringUserCommand = sendEmailForRegisteringUserCommand;
        }

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
                    if (claimsIdentity.HasClaim(m => m.Value == "Faculty"))
                        return RedirectToAction("Index", "Home");
                    else if (claimsIdentity.HasClaim(m => m.Value == "SiteAdmin"))
                        return RedirectToAction(MVC5.Admin.User.Index());
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
                if (await this._isAllowedToRegisterCommand(registerModel.EmailAddress).Execute())
                {
                    if (await this._sendEmailForRegisteringUserCommand(registerModel.EmailAddress).Execute())
                    {

                    }
                }
                else
                {
                    ModelState.AddModelError("", "Your email address is not in our system to be allowed to register. Contact the site administrator to get added.");
                }
            }
            //Here, means we're invalid, show the view again.
            return View();
        }

        [HttpGet]
        public virtual ActionResult Logout()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Public"); 
        }
	}
}