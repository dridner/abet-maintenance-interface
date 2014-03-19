using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Business.UserLogic
{
    public class SignInUserCommand : DBCommandBase<bool>
    {
        private string username;
        private string password;

        public SignInUserCommand(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public override bool Execute(IDBConnection conn)
        {
            return true;
        }
    }
}
