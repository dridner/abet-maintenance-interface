using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.Logic.CriteriaLogic
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
            }
            else
            {
                conn.ABETContext.Criterias.Add(this._model);
                modelToUpdate = this._model;
            }

            conn.ABETContext.SaveChanges();

            return modelToUpdate;
        }
    }
}
