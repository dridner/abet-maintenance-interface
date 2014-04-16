using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Model;

namespace AMI.Business.Logic.UserLogic
{
    public class SendEmailForRegisteringUserCommand : AsyncDBCommandBase<bool>
    {
        public delegate SendEmailForRegisteringUserCommand Factory(string emailAddress);

        private string _emailAddress;

        public SendEmailForRegisteringUserCommand(string emailAddress)
        {
            this._emailAddress = emailAddress;
        }

        internal async override Task<bool> Execute(Data.DataConnection.IDBConnection conn)
        {
            ApplicationUser user = await conn.UserManager.FindByEmailAsync(this._emailAddress);
            string newPassword = Guid.NewGuid().ToString("N");

            var result = await conn.UserManager.ChangePasswordAsync(user.Id, null, newPassword);

            //TODO We would send the email here.
            if(result.Succeeded)
                Console.WriteLine(newPassword);

            return result.Succeeded;
        }
    }
}
