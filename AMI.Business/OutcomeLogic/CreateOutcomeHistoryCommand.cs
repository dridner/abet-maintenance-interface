using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.OutcomeLogic
{
    public class CreateOutcomeHistoryCommand : AsyncDBCommandBase<OutcomeHistory>
    {
        private OutcomeHistory _model;

        public delegate CreateOutcomeHistoryCommand Factory(OutcomeHistory modelToSave);

        public CreateOutcomeHistoryCommand(OutcomeHistory classToSave)
        {
            this._model = classToSave;
        }

        internal override async Task<OutcomeHistory> Execute(IDBConnection conn)
        {
            conn.ABETContext.OutcomeHistory.Add(this._model);
            return this._model;
        }
    }
}
