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

        public override Class Execute(Data.DataConnection.IDBConnection conn)
        {
            Class classToUpdate = conn.ABETContext.Classes.Where(c => c.Id == this._class.Id).SingleOrDefault();
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
