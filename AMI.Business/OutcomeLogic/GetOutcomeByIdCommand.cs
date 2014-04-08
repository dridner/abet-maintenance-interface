using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.OutcomeLogic
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
            return await conn.ABETContext.Outcomes.FindAsync(this._id);
        }
    }
}
