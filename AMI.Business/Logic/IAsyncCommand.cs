﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Business.Logic
{
    public interface IAsyncCommand<T>
    {
        Task<T> Execute();
    }
}
