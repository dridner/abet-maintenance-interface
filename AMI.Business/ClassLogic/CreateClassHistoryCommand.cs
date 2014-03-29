using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.ClassLogic
{
    public class CreateClassHistoryCommand : DBCommandBase<ClassHistory>
    {
        private ClassHistory _model;

        public delegate CreateClassHistoryCommand Factory(ClassHistory modelToSave);

        public CreateClassHistoryCommand(ClassHistory classToSave)
        {
            this._model = classToSave;
        }

        public override async Task<ClassHistory> Execute(IDBConnection conn)
        {
            conn.ABETContext.ClassHistory.Add(this._model);
            return this._model;
        }
    }
}
