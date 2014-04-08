using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.ClassLogic
{
    public class SaveClassCommand : AsyncDBCommandBase<Class>
    {
        private Class _model;
        private CreateClassHistoryCommand.Factory _createHistoryCommand;

        public delegate SaveClassCommand Factory(Class modelToSave);

        public SaveClassCommand(Class classToSave, CreateClassHistoryCommand.Factory createHistory)
        {
            this._model = classToSave;
            this._createHistoryCommand = createHistory;
        }

        internal override async Task<Class> Execute(IDBConnection conn)
        {
            Class modelToUpdate = await conn.ABETContext.Classes.FindAsync(this._model.Id);
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
