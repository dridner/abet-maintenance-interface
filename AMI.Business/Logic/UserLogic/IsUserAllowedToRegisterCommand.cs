using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Model;

namespace AMI.Business.Logic.UserLogic
{
    public class IsUserAllowedToRegisterCommand : AsyncDBCommandBase<bool>
    {
        public delegate IsUserAllowedToRegisterCommand Factory(string emailAddress);

        private string _emailAddress;

        public IsUserAllowedToRegisterCommand(string emailAddress)
        {
            this._emailAddress = emailAddress;
        }

        internal async override Task<bool> Execute(Data.DataConnection.IDBConnection conn)
        {
            ApplicationUser user = await conn.UserManager.FindByEmailAsync(this._emailAddress);
            return user != null;
        }
    }
}
