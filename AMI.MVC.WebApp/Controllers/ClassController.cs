using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AMI.Business.ClassLogic;
using AMI.Model;

namespace AMI.MVC.WebApp.Controllers
{
    [Authorize]
    public partial class ClassController : AsyncController
    {
        private SaveClassCommand.Factory _saveClassCommand;
        private GetClassByIdCommand.Factory _getClassByIDCommand;
        private DeleteClassCommand.Factory _deleteClassCommand;

        public ClassController(SaveClassCommand.Factory saveClassCommand, GetClassByIdCommand.Factory getClassByIDCommand, DeleteClassCommand.Factory deleteClassCommand)
        {
            this._saveClassCommand = saveClassCommand;
            this._getClassByIDCommand = getClassByIDCommand;
            this._deleteClassCommand = deleteClassCommand;
        }

        [HttpGet]
        public virtual async Task<ActionResult> Edit(int id = 0)
        {
            var model = await this._getClassByIDCommand(id).Execute();
            if (model == null)
            {
                model = new Class();
            }

            return View(model);
        }

        [HttpPost]
        public virtual async Task<ActionResult> Edit(Class model)
        {
            try
            {
                await this._saveClassCommand(model).Execute();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public virtual async Task<ActionResult> Delete(int id)
        {
            await this._deleteClassCommand(id).Execute();
            return RedirectToAction(MVC5.Home.Index());
        }
    }
}
