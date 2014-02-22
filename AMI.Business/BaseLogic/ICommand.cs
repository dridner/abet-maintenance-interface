using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Business.BaseLogic
{
    public interface ICommand<T>
    {
        T Execute();
    }
}
