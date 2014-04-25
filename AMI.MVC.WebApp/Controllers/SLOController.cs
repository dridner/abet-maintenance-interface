using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AMI.Business.Logic.ClassLogic;
using AMI.Business.Logic.CriteriaLogic;
using AMI.Business.Logic.OutcomeLogic;
using AMI.Business.Logic.StudentLearningObjectiveLogic;
using AMI.Model;
using AMI.Model.Filters;
using AMI.MVC.WebApp.Models.SLO;

namespace AMI.MVC.WebApp.Controllers
{
    public partial class SLOController : Controller
    {
        private GetStudentLearningObjectiveByIDCommand.Factory _getSLOByIDCommand;
        private GetClassByIdCommand.Factory _getClassByIDCommand;
        private GetOutcomeByIDCommand.Factory _getOutcomeByIDCommand;
        private SaveStudentLearningObjectiveCommand.Factory _saveSLOCommand;
        private DeleteStudentLearningObjectiveCommand.Factory _deleteSLOCommand;
        private GetCriteriaListCommand.Factory _getCriteriaCommand;

        public SLOController(GetStudentLearningObjectiveByIDCommand.Factory getSLOByIDCommand,
            GetClassByIdCommand.Factory getClassByIDCommand,
            GetOutcomeByIDCommand.Factory getOutcomeByIDCommand,
            SaveStudentLearningObjectiveCommand.Factory saveSLOCommand,
            DeleteStudentLearningObjectiveCommand.Factory deleteSLOCommand,
            GetCriteriaListCommand.Factory getCriteriaCommand)
        {
            this._getSLOByIDCommand = getSLOByIDCommand;
            this._getClassByIDCommand = getClassByIDCommand;
            this._getOutcomeByIDCommand = getOutcomeByIDCommand;
            this._saveSLOCommand = saveSLOCommand;
            this._deleteSLOCommand = deleteSLOCommand;
            this._getCriteriaCommand = getCriteriaCommand;
        }

        [HttpGet]
        public virtual async Task<ActionResult> Edit(int ClassID, int SLOID = 0)
        {
            SLOModel model = new SLOModel();
            model.ClassID = ClassID;

            var slo = await this._getSLOByIDCommand(SLOID).Execute();
            if (slo != null)
            {
                model.ID = slo.Id;
                model.SupportedOutcomes = slo.SupportedOutcomes.ToList();
                model.Text = slo.Text;
            }

            return View(model);
        }

        [HttpPost]
        public virtual async Task<ActionResult> Edit(SLOModel slo)
        {
            var sloToUpdate = await this._getSLOByIDCommand(slo.ID).Execute();
            if (sloToUpdate != null)
            {
                sloToUpdate.Text = slo.Text;
            }
            else
            {
                sloToUpdate = new StudentLearningObjective();
                sloToUpdate.Class = await this._getClassByIDCommand(slo.ClassID, includeLearningObjectives:true).Execute();
                sloToUpdate.CreatedOn = DateTime.UtcNow;
            }

            await this._saveSLOCommand(sloToUpdate).Execute();

            return RedirectToAction(MVC5.Home.ActionNames.Index, MVC5.Home.Name);
        }

        [HttpGet]
        public virtual async Task<ActionResult> AddOutcomeToSLO(int sloID)
        {
            var sloToUpdate = await this._getSLOByIDCommand(sloID).Execute();
            OutcomeToSloModel model = new OutcomeToSloModel { SLOID = sloID };
            model.AllOutcomes = new List<Outcome>();
            var criterion = await this._getCriteriaCommand(new CriteriaFilter() { IncludeLearningObjectives = true, IncludeOutcomes = true }).Execute();
            foreach (var criteria in criterion)
            {
                model.AllOutcomes.AddRange(criteria.Outcomes.ToList());
            }

            return View(model);
        }

        [HttpPost]
        public virtual async Task<ActionResult> AddOutcomeToSLO(int sloID, int outcomeID)
        {
            var slo = await this._getSLOByIDCommand(sloID).Execute();
            slo.SupportedOutcomes.Add(await this._getOutcomeByIDCommand(outcomeID).Execute());
            await this._saveSLOCommand(slo).Execute();

            return RedirectToAction(MVC5.SLO.Edit(sloID));
        }

        [HttpGet]
        public virtual async Task<ActionResult> RemoveOutcomeFromSLO(int sloID, int ocID)
        {
            var sloToUpdate = await this._getSLOByIDCommand(sloID).Execute();
            sloToUpdate.SupportedOutcomes.Remove(sloToUpdate.SupportedOutcomes.Single(o => o.Id == ocID));
            await this._saveSLOCommand(sloToUpdate).Execute();

            return RedirectToAction(MVC5.SLO.Edit(sloToUpdate.Class.Id, sloID));
        }
        
        [HttpGet]
        public virtual async Task<ActionResult> Delete(int classID, int SLOid)
        {
            await this._deleteSLOCommand(SLOid).Execute();
            return RedirectToAction(MVC5.Class.Edit(classID));
        }
    }
}