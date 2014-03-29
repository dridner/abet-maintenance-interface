using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;

namespace AMI.Business.StudentLearningObjectiveLogic
{
    public class DeleteStudentLearningObjectiveCommand : DBCommandBase<bool>
    {
        private int _id;

        public delegate DeleteStudentLearningObjectiveCommand Factory(int id);

        public DeleteStudentLearningObjectiveCommand(int id)
        {
            this._id = id;
        }

        public override async Task<bool> Execute(IDBConnection conn)
        {
            StudentLearningObjective modelToDelete = await conn.ABETContext.StudentLearningObjectives.FindAsync(this._id);
            return modelToDelete == conn.ABETContext.StudentLearningObjectives.Remove(modelToDelete);
        }
    }
}
