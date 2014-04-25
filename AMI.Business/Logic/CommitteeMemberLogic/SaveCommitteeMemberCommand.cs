using System;
using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.Logic.CommitteeMemberLogic
{
    public class SaveCommitteeMemberCommand : AsyncDBCommandBase<CommitteeMember>
    {
        private CommitteeMember _model;
        private CreateCommitteeMemberHistoryCommand.Factory _createHistoryCommand;
        private GetCommitteeMemberByIDCommand.Factory _getByIDCommand;

        public delegate SaveCommitteeMemberCommand Factory(Class modelToSave);

        public SaveCommitteeMemberCommand(CommitteeMember classToSave, CreateCommitteeMemberHistoryCommand.Factory createHistory, GetCommitteeMemberByIDCommand.Factory getByIDCommand)
        {
            this._model = classToSave;
            this._createHistoryCommand = createHistory;
            this._getByIDCommand = getByIDCommand;
        }

        internal override async Task<CommitteeMember> Execute(IDBConnection conn)
        {
            CommitteeMember modelToUpdate = await this._getByIDCommand(this._model.Id).Execute(conn);
            if (modelToUpdate != null)
            {
                CommitteeMemberHistory history = Mapper.Map<CommitteeMemberHistory>(modelToUpdate);
                history.CommitteeMember = modelToUpdate;
                history.LastActiveDate = DateTime.UtcNow;
                await this._createHistoryCommand(history).Execute(conn);
                modelToUpdate.CommitteeRank = this._model.CommitteeRank;
                modelToUpdate.User = this._model.User;
                modelToUpdate.Class = this._model.Class;
                conn.ABETContext.SaveChanges();
            }
            else
            {
                conn.ABETContext.CommitteeMembers.Add(this._model);
                modelToUpdate = this._model;
            }

            return modelToUpdate;
        }
    }
}
