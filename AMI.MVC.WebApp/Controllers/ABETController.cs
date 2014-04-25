using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AMI.Business.Logic.CriteriaLogic;
using AMI.Model.Filters;

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
        public async virtual Task<ActionResult> Index()
        {
            var criterias = await this._getCriteriaListCommand(new CriteriaFilter()).Execute();

            return View(criterias);
        }
	}
}