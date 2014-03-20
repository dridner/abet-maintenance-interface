using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.Net;
using System.Security.Claims;

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

        public override async Task<bool> Execute(IDBConnection conn)
        {
            User user = conn.UserManager.Find(this.username, this.password);
            if (user != null)
            {
                var identity = await conn.UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
                identity.AddClaim(new Claim(ClaimTypes.Email, user.UserName));
                //TODO Finish
            }
            
            return true;
        }
    }
}
