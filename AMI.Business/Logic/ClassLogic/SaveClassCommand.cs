using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;
using System.Linq;
using System;

namespace AMI.Business.Logic.ClassLogic
{
    public class SaveClassCommand : AsyncDBCommandBase<Class>
    {
        private Class _model;
        private CreateClassHistoryCommand.Factory _createHistoryCommand;
        private GetClassByIdCommand.Factory _getByIDCommand;

        public delegate SaveClassCommand Factory(Class modelToSave);

        public SaveClassCommand(Class classToSave, CreateClassHistoryCommand.Factory createHistory, GetClassByIdCommand.Factory getByIDCommand)
        {
            this._model = classToSave;
            this._createHistoryCommand = createHistory;
            this._getByIDCommand = getByIDCommand;
        }

        internal override async Task<Class> Execute(IDBConnection conn)
        {
            Class modelToUpdate = await this._getByIDCommand(this._model.Id).Execute(conn);
            if (modelToUpdate != null)
            {
                ClassHistory history = Mapper.Map<ClassHistory>(modelToUpdate);
                history.Class = modelToUpdate;
                history.LastActiveDate = DateTime.UtcNow;
                await this._createHistoryCommand(history).Execute(conn);
                modelToUpdate.Name = this._model.Name;
                modelToUpdate.Number = this._model.Number;
                modelToUpdate.Prefix = this._model.Prefix;
            }
            else
            {
                conn.ABETContext.Classes.Add(this._model);
                modelToUpdate = this._model;
            }

            conn.ABETContext.SaveChanges();

            return modelToUpdate;
        }
    }
}
