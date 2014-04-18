using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;
using System.Data.Entity;
using System.Linq;

namespace AMI.Business.Logic.ClassLogic
{
    public class GetClassByIdCommand : AsyncDBCommandBase<Class>
    {
        private int _id;
        private bool _includeLearningObjectives;
        private bool _includeSupportedOutcomes;
        private bool _includeCommitteeMembers;

        public delegate GetClassByIdCommand Factory(int id, bool includeLearningObjectives = false, bool includeSupportedOutcomes = false, bool includeCommitteeMembers = false);

        public GetClassByIdCommand(int id, bool includeLearningObjectives = false, bool includeSupportedOutcomes = false, bool includeCommitteeMembers = false)
        {
            this._id = id;
            this._includeLearningObjectives = includeLearningObjectives;
            this._includeSupportedOutcomes = includeSupportedOutcomes;
            this._includeCommitteeMembers = includeCommitteeMembers;
        }

        internal override async Task<Class> Execute(IDBConnection conn)
        {
            IQueryable<Class> queryable = conn.ABETContext.Classes;
            if (this._includeCommitteeMembers)
            {
                queryable = queryable.Include(m => m.CommitteeMembers);
                queryable = queryable.Include("CommitteeMembers.User");
            }
            if (this._includeLearningObjectives)
            {
                queryable = queryable.Include(m => m.LearningObjectives);
            }
            if (this._includeSupportedOutcomes)
            {
                queryable.Include("LearningObjectives.SupportedOutcomes");
            }
            return await queryable.SingleAsync(c => c.Id == this._id);
        }
    }
}
