using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AMI.Business.Logic.CriteriaLogic;
using AMI.Business.Logic.OutcomeLogic;
using AMI.Model;
using AMI.Model.Filters;

namespace AMI.MVC.WebApp.Controllers
{
    [Authorize(Roles = "ABETAdmin")]
    public partial class ABETController : Controller
    {
        private readonly GetCriteriaListCommand.Factory _getCriteriaListCommand;
        private readonly GetCriteriaByIDCommand.Factory _getCriteriaByIdCommand;
        private readonly GetOutcomeByIDCommand.Factory _getOutcomeByIdCommand;
        private SaveOutcomeCommand.Factory _saveOutcomeCommand;

        public ABETController(GetCriteriaListCommand.Factory getCriteraListCommand, 
            GetCriteriaByIDCommand.Factory getCriteriaByIdCommand,
            GetOutcomeByIDCommand.Factory getOutcomeByIdCommand,
            SaveOutcomeCommand.Factory saveOutcomeCommand)
        {
            this._getCriteriaListCommand = getCriteraListCommand;
            this._getCriteriaByIdCommand = getCriteriaByIdCommand;
            this._getOutcomeByIdCommand = getOutcomeByIdCommand;
            this._saveOutcomeCommand = saveOutcomeCommand;
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

        [HttpGet]
        public async virtual Task<ActionResult> EditOutcome(int? id)
        {
            Outcome outcome = new Outcome();
            if (id.HasValue)
            {
                outcome = await this._getOutcomeByIdCommand(id.Value).Execute();
            }

            return PartialView(MVC5.ABET.Views._EditOutcome, outcome);
        }

        [HttpPost]
        public async virtual Task<ActionResult> EditOutcome(Outcome outcome)
        {
            return Json((await this._saveOutcomeCommand(outcome).Execute()).Id);
        }
	}
}