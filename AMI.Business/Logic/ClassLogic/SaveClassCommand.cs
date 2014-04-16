using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;
using System.Linq;

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
                await this._createHistoryCommand(history).Execute(conn);
                Mapper.Map(this._model, modelToUpdate);
                conn.ABETContext.SaveChanges();
            }
            else
            {
                conn.ABETContext.Classes.Add(this._model);
                modelToUpdate = this._model;
            }

            return modelToUpdate;
        }
    }
}
