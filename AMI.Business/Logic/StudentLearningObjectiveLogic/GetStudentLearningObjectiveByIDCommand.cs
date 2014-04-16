using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

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
            return await conn.ABETContext.StudentLearningObjectives.FindAsync(this._id);
        }
    }
}
