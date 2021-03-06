﻿using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;

namespace AMI.Business.Logic.StudentLearningObjectiveLogic
{
    public class DeleteStudentLearningObjectiveCommand : AsyncDBCommandBase<bool>
    {
        private int _id;

        public delegate DeleteStudentLearningObjectiveCommand Factory(int id);

        public DeleteStudentLearningObjectiveCommand(int id)
        {
            this._id = id;
        }

        internal override async Task<bool> Execute(IDBConnection conn)
        {
            StudentLearningObjective modelToDelete = await conn.ABETContext.StudentLearningObjectives.FindAsync(this._id);
            return modelToDelete == conn.ABETContext.StudentLearningObjectives.Remove(modelToDelete);
        }
    }
}
