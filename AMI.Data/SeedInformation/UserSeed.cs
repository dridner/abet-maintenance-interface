using System;
using System.Collections.Generic;
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
        public static ApplicationUser Seed(ABETContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            CreateUserWithUserNameAndEmail(userManager, "SYSTEM","USER", "SYSTEM_USER", "SystemUser@systemUser.com");
            CreateUserWithUserNameAndEmail(userManager, "Richard", "Molyet", "richard.molyet", "richard.molyet@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Weng", "Kang", "weng.kang", "weng.kang@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Jackson", "Carvalho", "jackson.carvalho", "jackson.carvalho@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Mohsin", "Jamali", "mohsin.jamali", "mohsin.jamali@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Brent", "Nowlin", "brent.nowlin", "brent.nowlin@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Devinder", "Kaur", "devinder.kaur", "devinder.kaur@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Ezzatollah", "Salari", "ezzatollah.salari", "ezzatollah.salari@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Gerald", "Heuring", "gerald.heuring", "gerald.heuring@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Mansoor", "Alam", "mansoor.alam", "mansoor.alam2@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Larry", "Thomas", "larry.thomas", "larry.thomas@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Gursel", "Serpen", "gursel.serpen", "gursel.serpen@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Junghwan", "Kim", "jung.kim", "jung.kim@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Roger", "King", "roger.king", "Roger.King@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Rashmi", "Jha", "rashmi.jha", "Rashmi.Jha@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Anthony", "Johnson", "anthony.johnson", "anthony.johnson@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Thomas", "Stuart", "thomas.stuart", "thomas.stuart@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Daniel", "Georgiev", "daniel.georgiev", "Daniel.Georgiev@utoledo.edu");
            CreateUserWithUserNameAndEmail(userManager, "Vijay", "Devabhaktuni", "vijay.devabhaktuni", "Vijay.Devabhaktuni@utoledo.edu");

            return userManager.FindByName("SYSTEM_USER");
        }

        private static bool CreateUserWithUserNameAndEmail(UserManager<ApplicationUser> manager, string firstName, string lastName, string username, string email)
        {
            ApplicationUser user = new ApplicationUser();
            user.FirstName = firstName;
            user.LastName = lastName;
            user.UserName = username;
            user.Email = email;

            return CreateUser(manager, user);
        }

        private static bool CreateUser(UserManager<ApplicationUser> manager, ApplicationUser user)
        {
            IdentityResult result = manager.Create(user);
            return result.Succeeded;
        }
    }
}
