using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DatabaseContext;
using AMI.Model;

namespace AMI.Data.SeedInformation
{
    public static class ProgramSeed
    {
        public static void Seed(ABETContext context)
        {
            Program program = new Program();
            program.Name = "EAC";
            context.Programs.Add(program);

            program = new Program();
            program.Name = "CAC";
            context.Programs.Add(program);
        }
    }
}
