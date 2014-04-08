using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;

namespace AMI.Business.ProgramLogic
{
    public class DeleteProgramCommand : AsyncDBCommandBase<bool>
    {
        private int _id;

        public delegate DeleteProgramCommand Factory(int id);

        public DeleteProgramCommand(int id)
        {
            this._id = id;
        }

        internal override async Task<bool> Execute(IDBConnection conn)
        {
            Program modelToDelete = await conn.ABETContext.Programs.FindAsync(this._id);
            return modelToDelete == conn.ABETContext.Programs.Remove(modelToDelete);
        }
    }
}
