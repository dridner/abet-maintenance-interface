using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AMI.Business.Logic.UserLogic;
using AMI.Model;
using AMI.Model.Filters;

namespace AMI.MVC.WebApp.Areas.Admin.Controllers
{
    [Authorize(Roles = "SiteAdmin")]
    public partial class UserController : Controller
    {
        private GetUserListCommand.Factory _getUserListCommand;

        public UserController(GetUserListCommand.Factory getUserListCommand)
        {
            this._getUserListCommand = getUserListCommand;
        }

        [HttpGet]
        public async virtual Task<ActionResult> Index()
        {
            return View(await this._getUserListCommand(null).Execute());
        }

        [ChildActionOnly]
        public virtual ActionResult NewUser()
        {
            var user = new ApplicationUser();

            return PartialView(MVC5.Admin.User.Views._AddNewUser, user);
        }
	}
}