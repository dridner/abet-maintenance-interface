using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;
using System.Data.Entity;

namespace AMI.Business.Logic.StudentLearningObjectiveLogic
{
    public class GetStudentLearningObjectiveByIDCommand : AsyncDBCommandBase<StudentLearningObjective>
    {
        private int _id;

        public delegate GetStudentLearningObjectiveByIDCommand Factory(int id);

        public GetStudentLearningObjectiveByIDCommand(int id)
        {
            this._id = id;
        }

        internal override async Task<StudentLearningObjective> Execute(IDBConnection conn)
        {
            return await conn.ABETContext.StudentLearningObjectives.Include(slo => slo.SupportedOutcomes).SingleAsync(s => s.Id == this._id);
        }
    }
}
