using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.ProgramLogic
{
    public class SaveProgramCommand : AsyncDBCommandBase<Program>
    {
        private Program _model;

        public delegate SaveProgramCommand Factory(Program classToSave);

        public SaveProgramCommand(Program modelToSave)
        {
            this._model = modelToSave;
        }

        internal override async Task<Program> Execute(IDBConnection conn)
        {
            Program modelToUpdate = await conn.ABETContext.Programs.FindAsync(this._model.ProgramId);
            if (modelToUpdate != null)
            {
                Mapper.Map(this._model, modelToUpdate);
                conn.ABETContext.SaveChanges();
            }
            else
            {
                conn.ABETContext.Programs.Add(this._model);
                modelToUpdate = this._model;
            }

            return modelToUpdate;
        }
    }
}
