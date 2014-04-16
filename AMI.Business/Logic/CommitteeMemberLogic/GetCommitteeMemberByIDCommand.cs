using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;

namespace AMI.Business.Logic.CommitteeMemberLogic
{
    public class GetCommitteeMemberByIDCommand : AsyncDBCommandBase<CommitteeMember>
    {
        private int _id;

        public delegate GetCommitteeMemberByIDCommand Factory(int id);

        public GetCommitteeMemberByIDCommand(int id)
        {
            this._id = id;
        }

        internal override async Task<CommitteeMember> Execute(IDBConnection conn)
        {
            return await conn.ABETContext.CommitteeMembers.FindAsync(this._id);
        }
    }
}
