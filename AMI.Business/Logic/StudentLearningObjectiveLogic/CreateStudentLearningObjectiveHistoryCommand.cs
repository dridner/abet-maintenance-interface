using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.Logic.StudentLearningObjectiveLogic
{
    public class CreateStudentLearningObjectiveHistoryCommand : AsyncDBCommandBase<StudentLearningObjectiveHistory>
    {
        private StudentLearningObjectiveHistory _model;

        public delegate CreateStudentLearningObjectiveHistoryCommand Factory(StudentLearningObjectiveHistory modelToSave);

        public CreateStudentLearningObjectiveHistoryCommand(StudentLearningObjectiveHistory modelToSave)
        {
            this._model = modelToSave;
        }

        internal override async Task<StudentLearningObjectiveHistory> Execute(IDBConnection conn)
        {
            conn.ABETContext.StudentLearningObjectiveHistory.Add(this._model);
            return this._model;
        }
    }
}
