using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DatabaseContext;
using AMI.Model;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AMI.Data.DataConnection
{
    public interface IDBConnection : IDisposable
    {
        IABETContext ABETContext { get; }
        IdentityDbContext<User> SecurityContext { get; }

        void SaveAllChanges();
    }
}
