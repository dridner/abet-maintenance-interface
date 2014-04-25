using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AMI.Business.Logic.CriteriaLogic;
using AMI.Model;
using AMI.Model.Filters;

namespace AMI.MVC.WebApp.Controllers
{
    [Authorize(Roles = "ABETAdmin")]
    public partial class ABETController : Controller
    {
        private readonly GetCriteriaListCommand.Factory _getCriteriaListCommand;
        private readonly GetCriteriaByIDCommand.Factory _getCriteriaByIdCommand;

        public ABETController(GetCriteriaListCommand.Factory getCriteraListCommand, GetCriteriaByIDCommand.Factory getCriteriaByIdCommand)
        {
            this._getCriteriaListCommand = getCriteraListCommand;
            this._getCriteriaByIdCommand = getCriteriaByIdCommand;
        }

        [HttpGet]
        public async virtual Task<ActionResult> Index()
        {
            CriteriaFilter filter = new CriteriaFilter();
            filter.IncludeOutcomes = true;
            List<Criteria> criterias = await this._getCriteriaListCommand(filter).Execute();

            return View(criterias);
        }

        [HttpGet]
        public async virtual Task<ActionResult> Edit(int id)
        {
            Criteria criteria = await this._getCriteriaByIdCommand(id).Execute();

            return View(criteria);
        }
	}
}