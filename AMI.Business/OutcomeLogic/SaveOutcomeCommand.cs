using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.OutcomeLogic
{
    public class SaveOutcomeCommand : AsyncDBCommandBase<Outcome>
    {
        private Outcome _model;

        public delegate SaveOutcomeCommand Factory(Outcome classToSave);

        public SaveOutcomeCommand(Outcome modelToSave)
        {
            this._model = modelToSave;
        }

        internal override async Task<Outcome> Execute(IDBConnection conn)
        {
            Outcome modelToUpdate = await conn.ABETContext.Outcomes.FindAsync(this._model.Id);
            if (modelToUpdate != null)
            {
                Mapper.Map(this._model, modelToUpdate);
                conn.ABETContext.SaveChanges();
            }
            else
            {
                conn.ABETContext.Outcomes.Add(this._model);
                modelToUpdate = this._model;
            }

            return modelToUpdate;
        }
    }
}
