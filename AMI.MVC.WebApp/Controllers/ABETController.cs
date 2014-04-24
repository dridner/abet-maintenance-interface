using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AMI.Business.Logic.CriteriaLogic;

namespace AMI.MVC.WebApp.Controllers
{
    [Authorize(Roles = "ABETAdmin")]
    public partial class ABETController : Controller
    {
        private readonly GetCriteriaListCommand.Factory _getCriteriaListCommand;

        public ABETController(GetCriteriaListCommand.Factory getCriteraListCommand)
        {
            this._getCriteriaListCommand = getCriteraListCommand;
        }

        [HttpGet]
        public virtual ActionResult Index()
        {


            return View();
        }
	}
}