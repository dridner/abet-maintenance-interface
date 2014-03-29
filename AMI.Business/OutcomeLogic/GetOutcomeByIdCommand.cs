using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.OutcomeLogic
{
    public class GetOutcomeByIdCommand : DBCommandBase<Outcome>
    {
        private int _id;

        public delegate GetOutcomeByIdCommand Factory(int id);

        public GetOutcomeByIdCommand(int id)
        {
            this._id = id;
        }

        public override async Task<Outcome> Execute(IDBConnection conn)
        {
            return await conn.ABETContext.Outcomes.FindAsync(this._id);
        }
    }
}
