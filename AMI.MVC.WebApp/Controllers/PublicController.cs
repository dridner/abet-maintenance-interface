using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMI.MVC.WebApp.Controllers
{
    [AllowAnonymous]
    public partial class PublicController : Controller
    {


        public virtual ActionResult Index()
        {
            return View();
        }
	}
}