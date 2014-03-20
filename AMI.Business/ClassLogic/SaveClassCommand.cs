using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Model;
using AMI.Data.DatabaseContext;
using AMI.Business.BaseLogic;

namespace AMI.Business.ClassLogic
{
    public class SaveClassCommand : DBCommandBase<Class>
    {
        private Class _class;

        public SaveClassCommand(Class classToSave)
        {
            this._class = classToSave;
        }

        public override async Task<Class> Execute(Data.DataConnection.IDBConnection conn)
        {
            Class classToUpdate = await conn.ABETContext.Classes.FindAsync(this._class.Id);
            if (classToUpdate != null)
            {
                //this._class.CopyTo(classToUpdate);
                conn.ABETContext.SaveChanges();
            }
            else
            {
                classToUpdate = this._class;
                conn.ABETContext.Classes.Add(this._class);
            }

            return classToUpdate;
        }
    }
}
