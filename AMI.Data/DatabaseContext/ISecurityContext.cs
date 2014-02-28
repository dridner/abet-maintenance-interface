using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using AMI.Model;

namespace AMI.Data.DatabaseContext
{
    public interface ISecurityContext
    {
        IDbSet<User> Users { get; set; }
        IDbSet<Role> Roles { get; set; }
    }
}
