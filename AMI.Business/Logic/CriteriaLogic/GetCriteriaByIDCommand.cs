using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.Logic.CriteriaLogic
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
            return await conn.ABETContext.Criterias.Include(m => m.Outcomes).Where(m => m.Id == this._id).SingleAsync();
        }
    }
}
