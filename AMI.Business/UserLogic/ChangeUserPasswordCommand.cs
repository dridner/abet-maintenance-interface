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
    public class ChangeUserPasswordCommand : DBCommandBase<IdentityResult>
    {
        private User _user;
        private string _oldPassword;
        private string _newPassword;

        public ChangeUserPasswordCommand(User user, string oldPassword, string newPassword)
        {
            this._user = user;
            this._oldPassword = oldPassword;
            this._newPassword = newPassword;
        }

        public override async Task<IdentityResult> Execute(IDBConnection conn)
        {
            return await conn.UserManager.ChangePasswordAsync(this._user.Id, this._oldPassword, this._newPassword);
        }
    }
}
