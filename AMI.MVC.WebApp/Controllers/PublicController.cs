using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AMI.Business.Logic.ClassLogic;
using AMI.Business.Logic.CriteriaLogic;
using AMI.Model.Filters;
using AMI.MVC.WebApp.Models.Public;

namespace AMI.MVC.WebApp.Controllers
{
    [AllowAnonymous]
    public partial class PublicController : AsyncController
    {
        private GetClassListCommand.Factory _getClassListCommand;
        private GetClassByIdCommand.Factory _getClassById;
        private GetCriteriaListCommand.Factory _getCriteriaListCommand;
        
        public PublicController(GetClassListCommand.Factory getClassListCommand, GetClassByIdCommand.Factory getClassById, GetCriteriaListCommand.Factory getCriteriaListCommand)
        {
            this._getClassListCommand = getClassListCommand;
            this._getClassById = getClassById;
            this._getCriteriaListCommand = getCriteriaListCommand;
        }

        [HttpGet]
        public async virtual Task<ActionResult> Index()
        {
            var classList = await this._getClassListCommand(new ClassFilter()).Execute();
            return View(classList);
        }

        [HttpGet]
        public async virtual Task<ActionResult> ClassDetails(int id)
        {

            var theClass = await this._getClassById(id, includeLearningObjectives:true, includeSupportedOutcomes: true, includeCommitteeMembers: true).Execute();
            CriteriaFilter criteriaFilter = new CriteriaFilter() 
            {
                IncludeOutcomes = true,
                IncludeLearningObjectives = true
            };
            var criterias = await this._getCriteriaListCommand(null).Execute();
            var model = new ClassDetailModel();
            model.Class = theClass;
            model.Criterias = criterias;

            return PartialView(MVC5.Public.Views._ClassDetails, model);
        }
	}
}