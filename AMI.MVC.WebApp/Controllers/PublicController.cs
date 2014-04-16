using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AMI.Business.Logic.ClassLogic;

namespace AMI.MVC.WebApp.Controllers
{
    [AllowAnonymous]
    public partial class PublicController : AsyncController
    {
        private GetClassListCommand.Factory _getClassListCommand;
        
        public PublicController(GetClassListCommand.Factory getClassListCommand)
        {
            this._getClassListCommand = getClassListCommand;
        }

        public async virtual Task<ActionResult> Index()
        {
            var classList = await this._getClassListCommand(null).Execute();
            return View();
        }
	}
}