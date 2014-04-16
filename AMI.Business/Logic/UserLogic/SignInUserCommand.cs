using AMI.Business.Logic;
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

namespace AMI.Business.Logic.UserLogic
{
    public class SignInUserCommand : AsyncDBCommandBase<ClaimsIdentity>
    {
        private string username;
        private string password;

        public SignInUserCommand(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        internal override async Task<ClaimsIdentity> Execute(IDBConnection conn)
        {
            ClaimsIdentity identity = null;
            ApplicationUser user = await conn.UserManager.FindAsync(this.username, this.password);
            if (user != null)
            {
                identity = await conn.UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
                identity.AddClaim(new Claim(ClaimTypes.Email, user.UserName));
            }

            return identity;
        }
    }
}
