using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.Logic.OutcomeLogic
{
    public class CreateOutcomeHistoryCommand : AsyncDBCommandBase<OutcomeHistory>
    {
        public delegate CreateOutcomeHistoryCommand Factory(OutcomeHistory modelToSave);

        private OutcomeHistory _model;

        public CreateOutcomeHistoryCommand(OutcomeHistory modelToSave)
        {
            this._model = modelToSave;
        }

        internal override async Task<OutcomeHistory> Execute(IDBConnection conn)
        {
            conn.ABETContext.OutcomeHistory.Add(this._model);
            return this._model;
        }
    }
}
