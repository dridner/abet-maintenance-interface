using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;

namespace AMI.Business.CommitteeMemberLogic
{
    public class CreateCommitteeMemberHistoryCommand : AsyncDBCommandBase<CommitteeMemberHistory>
    {
        private CommitteeMemberHistory _model;

        public delegate CreateCommitteeMemberHistoryCommand Factory(CommitteeMemberHistory modelToSave);

        public CreateCommitteeMemberHistoryCommand(CommitteeMemberHistory classToSave)
        {
            this._model = classToSave;
        }

        internal override async Task<CommitteeMemberHistory> Execute(IDBConnection conn)
        {
            conn.ABETContext.CommitteeMemberHistory.Add(this._model);
            return this._model;
        }
    }
}
