using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;

namespace AMI.Business.Logic.OutcomeLogic
{
    public class DeleteOutcomeCommand : AsyncDBCommandBase<bool>
    {
        private int _id;

        public delegate DeleteOutcomeCommand Factory(int id);

        public DeleteOutcomeCommand(int id)
        {
            this._id = id;
        }

        internal override async Task<bool> Execute(IDBConnection conn)
        {
            Outcome modelToDelete = await conn.ABETContext.Outcomes.FindAsync(this._id);
            return modelToDelete == conn.ABETContext.Outcomes.Remove(modelToDelete);
        }
    }
}
