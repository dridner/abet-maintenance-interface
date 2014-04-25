using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;

namespace AMI.Business.Logic.CriteriaLogic
{
    public class DeleteCriteriaCommand : AsyncDBCommandBase<bool>
    {
        private int _id;

        public delegate DeleteCriteriaCommand Factory(int id);

        public DeleteCriteriaCommand(int id)
        {
            this._id = id;
        }

        internal override async Task<bool> Execute(IDBConnection conn)
        {
            Criteria modelToDelete = await conn.ABETContext.Criterias.FindAsync(this._id);
            return modelToDelete == conn.ABETContext.Criterias.Remove(modelToDelete);
        }
    }
}
