using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DatabaseContext;

namespace AMI.Data.DataConnection
{
    public interface IDBConnection
    {
        IABETContext ABETContext { get; }
        ISecurityContext SecurityContext { get; }
    }
}
