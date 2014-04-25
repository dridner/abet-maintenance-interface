using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.Logic
{
    public abstract class AsyncCommandBase<T> : IAsyncCommand<T>
    {
        static AsyncCommandBase()
        {
            Mapper.CreateMap<Class, ClassHistory>();
            Mapper.CreateMap<CommitteeMember, CommitteeMemberHistory>();
            Mapper.CreateMap<StudentLearningObjective, StudentLearningObjectiveHistory>();
            Mapper.CreateMap<Outcome, OutcomeHistory>();
        }

        public abstract Task<T> Execute();
    }
}
