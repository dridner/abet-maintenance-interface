﻿using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;

namespace AMI.Business.StudentLearningObjectiveLogic
{
    public class SaveStudentLearningObjectiveCommand : AsyncDBCommandBase<StudentLearningObjective>
    {
        private StudentLearningObjective _model;
        private CreateStudentLearningObjectiveHistoryCommand.Factory _createHistoryCommand;
        private GetStudentLearningObjectiveByIDCommand.Factory _getByIDCommand;

        public delegate SaveStudentLearningObjectiveCommand Factory(Outcome modelToSave);

        public SaveStudentLearningObjectiveCommand(StudentLearningObjective modelToSave, CreateStudentLearningObjectiveHistoryCommand.Factory createHistory, GetStudentLearningObjectiveByIDCommand.Factory getByIDCommand)
        {
            this._model = modelToSave;
            this._createHistoryCommand = createHistory;
            this._getByIDCommand = getByIDCommand;
        }

        internal override async Task<StudentLearningObjective> Execute(IDBConnection conn)
        {
            StudentLearningObjective modelToUpdate = await this._getByIDCommand(this._model.SLOId).Execute(conn);
            if (modelToUpdate != null)
            {
                StudentLearningObjectiveHistory history = Mapper.Map<StudentLearningObjectiveHistory>(modelToUpdate);
                await this._createHistoryCommand(history).Execute(conn);
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
