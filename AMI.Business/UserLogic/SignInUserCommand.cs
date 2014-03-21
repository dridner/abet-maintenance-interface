using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System.Security.Claims;

namespace AMI.Business.UserLogic
{
    public class SignInUserCommand : DBCommandBase<ClaimsIdentity>
    {
        private string username;
        private string password;

        public SignInUserCommand(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public override async Task<ClaimsIdentity> Execute(IDBConnection conn)
        {
            ClaimsIdentity identity = null;
            User user = conn.UserManager.Find(this.username, this.password);
            if (user != null)
            {
                identity = await conn.UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
                identity.AddClaim(new Claim(ClaimTypes.Email, user.UserName));
            }

            return identity;
        }
    }
}
