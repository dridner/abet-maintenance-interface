﻿using System.Threading.Tasks;
using AMI.Business.BaseLogic;
using AMI.Data.DataConnection;
using AMI.Model;

namespace AMI.Business.ClassLogic
{
    public class DeleteClassCommand : DBCommandBase<bool>
    {
        private int _id;

        public delegate DeleteClassCommand Factory(int id);

        public DeleteClassCommand(int id)
        {
            this._id = id;
        }

        public override async Task<bool> Execute(IDBConnection conn)
        {
            Class modelToDelete = await conn.ABETContext.Classes.FindAsync(this._id);
            return modelToDelete == conn.ABETContext.Classes.Remove(modelToDelete);
        }
    }
}
