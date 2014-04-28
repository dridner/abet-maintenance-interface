using System;
using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.Logic.OutcomeLogic
{
    public class SaveOutcomeCommand : AsyncDBCommandBase<Outcome>
    {
        private Outcome _model;
        private CreateOutcomeHistoryCommand.Factory _createHistoryCommand;
        private GetOutcomeByIDCommand.Factory _getByIDCommand;

        public delegate SaveOutcomeCommand Factory(Outcome modelToSave);

        public SaveOutcomeCommand(Outcome modelToSave, CreateOutcomeHistoryCommand.Factory createHistory, GetOutcomeByIDCommand.Factory getByIDCommand)
        {
            this._model = modelToSave;
            this._createHistoryCommand = createHistory;
            this._getByIDCommand = getByIDCommand;
        }

        internal override async Task<Outcome> Execute(IDBConnection conn)
        {
            Outcome modelToUpdate = await this._getByIDCommand(this._model.Id).Execute(conn);
            if (modelToUpdate != null)
            {
                OutcomeHistory history = Mapper.Map<OutcomeHistory>(modelToUpdate);
                history.Outcome = modelToUpdate;
                history.LastActiveDate = DateTime.UtcNow;
                await this._createHistoryCommand(history).Execute(conn);
                modelToUpdate.Text = this._model.Text;
            }
            else
            {
                conn.ABETContext.Outcomes.Add(this._model);
                modelToUpdate = this._model;
            }

            conn.ABETContext.SaveChanges();

            return modelToUpdate;
        }
    }
}
