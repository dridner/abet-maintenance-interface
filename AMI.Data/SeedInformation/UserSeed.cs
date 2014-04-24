using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DatabaseContext;
using AMI.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AMI.Data.SeedInformation
{
    public static class UserSeed
    {
        public static ApplicationUser Seed(UserManager<ApplicationUser> userManager, ABETContext context)
        {
            CreateUserWithUserNameEmailAndRoleName(userManager, "SYSTEM","USER", "SYSTEM_USER", "SystemUser@systemUser.com");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Richard", "Molyet", "richard.molyet", "richard.molyet@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Weng", "Kang", "weng.kang", "weng.kang@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Jackson", "Carvalho", "jackson.carvalho", "jackson.carvalho@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Mohsin", "Jamali", "mohsin.jamali", "mohsin.jamali@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Brent", "Nowlin", "brent.nowlin", "brent.nowlin@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Devinder", "Kaur", "devinder.kaur", "devinder.kaur@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Ezzatollah", "Salari", "ezzatollah.salari", "ezzatollah.salari@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Gerald", "Heuring", "gerald.heuring", "gerald.heuring@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Mansoor", "Alam", "mansoor.alam", "mansoor.alam2@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Larry", "Thomas", "larry.thomas", "larry.thomas@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Gursel", "Serpen", "gursel.serpen", "gursel.serpen@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Junghwan", "Kim", "jung.kim", "jung.kim@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Roger", "King", "roger.king", "Roger.King@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Rashmi", "Jha", "rashmi.jha", "Rashmi.Jha@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Anthony", "Johnson", "anthony.johnson", "anthony.johnson@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Thomas", "Stuart", "thomas.stuart", "thomas.stuart@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Daniel", "Georgiev", "daniel.georgiev", "Daniel.Georgiev@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Vijay", "Devabhaktuni", "vijay.devabhaktuni", "Vijay.Devabhaktuni@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Krishna", "Shenai", "krishna.shenai", "krishna.shenai@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Henry", "Ledgard", "henry.ledgard", "henry.ledgard@utoledo.edu", "Faculty");
            CreateUserWithUserNameEmailAndRoleName(userManager, "David", "Ridner", "david.ridner", "david.ridner@gmail.com", "SiteAdmin");
            CreateUserWithUserNameEmailAndRoleName(userManager, "Don", "Hartman", "don.hartman", "donl.hartman@yahoo.com", "ABETAdmin");

            return userManager.FindByName("SYSTEM_USER");
        }

        private static bool CreateUserWithUserNameEmailAndRoleName(UserManager<ApplicationUser> manager, string firstName, string lastName, string username, string email, params string[] roles)
        {
            ApplicationUser user = new ApplicationUser();
            user.FirstName = firstName;
            user.LastName = lastName;
            user.UserName = username;
            user.Email = email;
            user.CreatedOn = DateTime.UtcNow;

            if (CreateUser(manager, user))
            {
                foreach (string role in roles)
                {
                    if(!manager.AddToRole(user.Id, role).Succeeded)
                    {
                        Debugger.Break();
                    }
                }
            }

            return true;
        }

        private static bool CreateUser(UserManager<ApplicationUser> manager, ApplicationUser user)
        {
            IdentityResult result = manager.Create(user, "TempPassword");
            return result.Succeeded;
        }
    }
}
