using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMI.MVC.WebApp.Areas.Admin.Controllers
{
    [Authorize(Roles = "SiteAdmin")]
    public partial class UserController : Controller
    {
        //
        // GET: /Admin/User/
        public virtual ActionResult Index()
        {
            return View();
        }
	}
}