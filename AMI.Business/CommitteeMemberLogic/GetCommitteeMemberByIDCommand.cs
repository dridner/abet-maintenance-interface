using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;

namespace AMI.Business.CommitteeMemberLogic
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
