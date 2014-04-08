using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using Microsoft.AspNet.Identity;

namespace AMI.Business.UserLogic
{
    public class RegisterUserCommand : AsyncDBCommandBase<IdentityResult>
    {
        private ApplicationUser _user;
        private string _password;

        public RegisterUserCommand(ApplicationUser user, string password)
        {
            this._user = user;
            this._password = password;
        }

        internal override async Task<IdentityResult> Execute(IDBConnection conn)
        {
            var manager = conn.UserManager;
            var result = await manager.CreateAsync(this._user, this._password);
            
            return result;
        }
    }
}
