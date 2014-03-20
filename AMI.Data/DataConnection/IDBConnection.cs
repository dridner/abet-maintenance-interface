using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DatabaseContext;
using AMI.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace AMI.Data.DataConnection
{
    public interface IDBConnection : IDisposable
    {
        ABETContext ABETContext { get; }
        UserManager<User> UserManager { get; }

        void SaveAllChanges();
    }
}
