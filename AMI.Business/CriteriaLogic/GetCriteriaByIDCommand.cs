using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.ProgramLogic
{
    public class GetCriteriaByIDCommand : AsyncDBCommandBase<Criteria>
    {
        private int _id;

        public delegate GetCriteriaByIDCommand Factory(int id);

        public GetCriteriaByIDCommand(int id)
        {
            this._id = id;
        }

        internal override async Task<Criteria> Execute(IDBConnection conn)
        {
            return await conn.ABETContext.Criterias.FindAsync(this._id);
        }
    }
}
