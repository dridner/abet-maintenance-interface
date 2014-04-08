using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.ClassLogic
{
    public class GetClassByIdCommand : AsyncDBCommandBase<Class>
    {
        private int _id;

        public delegate GetClassByIdCommand Factory(int id);

        public GetClassByIdCommand(int id)
        {
            this._id = id;
        }

        internal override async Task<Class> Execute(IDBConnection conn)
        {
            return await conn.ABETContext.Classes.FindAsync(this._id);
        }
    }
}
