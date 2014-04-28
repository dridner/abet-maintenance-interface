using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AMI.Data.DataConnection;
using AMI.Model;

namespace AMI.Business.Logic.OutcomeLogic
{
    public class GetOutcomeByIDCommand : AsyncDBCommandBase<Outcome>
    {
        private int _id;

        public delegate GetOutcomeByIDCommand Factory(int id);

        public GetOutcomeByIDCommand(int id)
        {
            this._id = id;
        }

        internal override async Task<Outcome> Execute(IDBConnection conn)
        {
            return await conn.ABETContext.Outcomes.Include(o => o.Criteria).Where(o => o.Id == this._id).SingleAsync();
        }
    }
}
