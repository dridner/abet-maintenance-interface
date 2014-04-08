using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;

namespace AMI.Business.CommitteeMemberLogic
{
    public class DeleteCommitteeMemberCommand : AsyncDBCommandBase<bool>
    {
        private int _id;

        public delegate DeleteCommitteeMemberCommand Factory(int id);

        public DeleteCommitteeMemberCommand(int id)
        {
            this._id = id;
        }

        internal override async Task<bool> Execute(IDBConnection conn)
        {
            CommitteeMember modelToDelete = await conn.ABETContext.CommitteeMembers.FindAsync(this._id);
            return modelToDelete == conn.ABETContext.CommitteeMembers.Remove(modelToDelete);
        }
    }
}
