using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AMI.Business.Logic.ClassLogic;
using AMI.Model;
using AMI.Model.Filters;
using AMI.MVC.WebApp.Models.Classes;

namespace AMI.MVC.WebApp.Controllers
{
    [Authorize]
    public partial class ClassController : AsyncController
    {
        private GetClassListCommand.Factory _getClassListCommand;
        private SaveClassCommand.Factory _saveClassCommand;
        private GetClassByIdCommand.Factory _getClassByIDCommand;
        private DeleteClassCommand.Factory _deleteClassCommand;

        public ClassController(GetClassListCommand.Factory getClassListCommand, 
            SaveClassCommand.Factory saveClassCommand, 
            GetClassByIdCommand.Factory getClassByIDCommand, 
            DeleteClassCommand.Factory deleteClassCommand)
        {
            this._getClassListCommand = getClassListCommand;
            this._saveClassCommand = saveClassCommand;
            this._getClassByIDCommand = getClassByIDCommand;
            this._deleteClassCommand = deleteClassCommand;
        }

        [HttpGet]
        public virtual async Task<ActionResult> ViewAll(ClassListModel model)
        {
            ClassFilter filter = new ClassFilter();
            if (model != null)
            {
                filter.Name = model.Name;
                filter.Number = model.Number;
                filter.Prefix = model.Prefix;
            }
            else
            {
                model = new ClassListModel();
            }

            List<Class> classes = await this._getClassListCommand(filter).Execute();
            model.Classes = classes ?? new List<Class>();

            return View(model);
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
                return RedirectToAction(MVC5.Home.Index());
            }
        }

        [HttpPost]
        public virtual async Task<ActionResult> Delete(int id)
        {
            await this._deleteClassCommand(id).Execute();
            return RedirectToAction(MVC5.Class.ViewAll());
        }
    }
}
