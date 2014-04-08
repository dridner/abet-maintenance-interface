using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.ProgramLogic
{
    public class GetProgramByIdCommand : AsyncDBCommandBase<Program>
    {
        private int _id;

        public delegate GetProgramByIdCommand Factory(int id);

        public GetProgramByIdCommand(int id)
        {
            this._id = id;
        }

        internal override async Task<Program> Execute(IDBConnection conn)
        {
            return await conn.ABETContext.Programs.FindAsync(this._id);
        }
    }
}
