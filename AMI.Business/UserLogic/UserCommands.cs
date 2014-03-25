using AMI.Model;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Business.UserLogic
{
    public static class UserCommands
    {
        public static Task<ClaimsIdentity> SignIn(string username, string password)
        {
            return new SignInUserCommand(username, password).Execute();
        }

        public static Task<IdentityResult> ChangePassword(ApplicationUser user, string oldPassword, string newPassword)
        {
            return new ChangeUserPasswordCommand(user, oldPassword, newPassword).Execute();
        }
    }
}
