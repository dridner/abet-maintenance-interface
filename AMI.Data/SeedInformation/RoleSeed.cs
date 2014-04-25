using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Model;
using Microsoft.AspNet.Identity;

namespace AMI.Data.SeedInformation
{
    public static class RoleSeed
    {
        public static void Seed(RoleManager<ApplicationRole> roleManager)
        {
            roleManager.Create(new ApplicationRole("SiteAdmin"));
            roleManager.Create(new ApplicationRole("Faculty"));
            roleManager.Create(new ApplicationRole("ABETAdmin"));
        }
    }
}
