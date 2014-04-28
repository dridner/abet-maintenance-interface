using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AMI.Data.DataConnection;
using AMI.Model;

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
