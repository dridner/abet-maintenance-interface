using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.ProgramLogic
{
    public class SaveCriteriaCommand : AsyncDBCommandBase<Criteria>
    {
        private Criteria _model;

        public delegate SaveCriteriaCommand Factory(Criteria classToSave);

        public SaveCriteriaCommand(Criteria modelToSave)
        {
            this._model = modelToSave;
        }

        internal override async Task<Criteria> Execute(IDBConnection conn)
        {
            Criteria modelToUpdate = await conn.ABETContext.Criterias.FindAsync(this._model.Id);
            if (modelToUpdate != null)
            {
                Mapper.Map(this._model, modelToUpdate);
                conn.ABETContext.SaveChanges();
            }
            else
            {
                conn.ABETContext.Criterias.Add(this._model);
                modelToUpdate = this._model;
            }

            return modelToUpdate;
        }
    }
}
