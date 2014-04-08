using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.StudentLearningObjectiveLogic
{
    public class CreateStudentLearningObjectiveHistoryCommand : AsyncDBCommandBase<StudentLearningObjectiveHistory>
    {
        private StudentLearningObjectiveHistory _model;

        public delegate CreateStudentLearningObjectiveHistoryCommand Factory(StudentLearningObjectiveHistory modelToSave);

        public CreateStudentLearningObjectiveHistoryCommand(StudentLearningObjectiveHistory classToSave)
        {
            this._model = classToSave;
        }

        internal override async Task<StudentLearningObjectiveHistory> Execute(IDBConnection conn)
        {
            conn.ABETContext.StudentLearningObjectiveHistory.Add(this._model);
            return this._model;
        }
    }
}
