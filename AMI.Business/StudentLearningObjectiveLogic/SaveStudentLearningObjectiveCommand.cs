using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.StudentLearningObjectiveLogic
{
    public class SaveStudentLearningObjectiveCommand : DBCommandBase<StudentLearningObjective>
    {
        private StudentLearningObjective _model;

        public delegate SaveStudentLearningObjectiveCommand Factory(StudentLearningObjective classToSave);

        public SaveStudentLearningObjectiveCommand(StudentLearningObjective modelToSave)
        {
            this._model = modelToSave;
        }

        public override async Task<StudentLearningObjective> Execute(IDBConnection conn)
        {
            StudentLearningObjective modelToUpdate = await conn.ABETContext.StudentLearningObjectives.FindAsync(this._model.SLOId);
            if (modelToUpdate != null)
            {
                Mapper.Map(this._model, modelToUpdate);
                conn.ABETContext.SaveChanges();
            }
            else
            {
                conn.ABETContext.StudentLearningObjectives.Add(this._model);
                modelToUpdate = this._model;
            }

            return modelToUpdate;
        }
    }
}
