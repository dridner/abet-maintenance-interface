using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;
using System.Data.Entity;

namespace AMI.Business.Logic.ClassLogic
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
            return await conn.ABETContext.Classes.Include(c => c.LearningObjectives).SingleAsync(c => c.Id == this._id);
        }
    }
}
