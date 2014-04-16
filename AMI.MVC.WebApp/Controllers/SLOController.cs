using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AMI.Business.Logic.ClassLogic;
using AMI.Business.Logic.StudentLearningObjectiveLogic;
using AMI.Model;

namespace AMI.MVC.WebApp.Controllers
{
    public partial class SLOController : Controller
    {
        private GetStudentLearningObjectiveByIDCommand.Factory _getSLOByIDCommand;
        private GetClassByIdCommand.Factory _getClassByIDCommand;
        private SaveStudentLearningObjectiveCommand.Factory _saveSLOCommand;
        private DeleteStudentLearningObjectiveCommand.Factory _deleteSLOCommand;

        public SLOController(GetStudentLearningObjectiveByIDCommand.Factory getSLOByIDCommand,
        GetClassByIdCommand.Factory getClassByIDCommand, 
        SaveStudentLearningObjectiveCommand.Factory saveSLOCommand,
        DeleteStudentLearningObjectiveCommand.Factory deleteSLOCommand)
        {
            this._getSLOByIDCommand = getSLOByIDCommand;
            this._getClassByIDCommand = getClassByIDCommand;
            this._saveSLOCommand = saveSLOCommand;
            this._deleteSLOCommand = deleteSLOCommand;
        }

        [HttpGet]
        public virtual async Task<ActionResult> Edit(int ClassID, int SLOID = 0)
        {

            return View();
        }

        [HttpPost]
        public virtual async Task<ActionResult> Edit(StudentLearningObjective slo)
        {
            var sloToUpdate = await this._getSLOByIDCommand(slo.Id).Execute();
            if (sloToUpdate != null)
            {
                sloToUpdate.Text = slo.Text;
            }
            else
            {
                sloToUpdate = slo;
                sloToUpdate.Class = await this._getClassByIDCommand(slo.Class.Id).Execute();
                sloToUpdate.CreatedOn = DateTime.UtcNow;
            }

            await this._saveSLOCommand(sloToUpdate).Execute();

            return RedirectToAction(MVC5.Home.ActionNames.Index, MVC5.Home.Name);
        }
	}
}