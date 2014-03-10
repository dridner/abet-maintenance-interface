using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Model;
using AMI.Data.DatabaseContext;
using AMI.Business.BaseLogic;

namespace AMI.Business.Logic.Class
{
    public class SaveClassCommand : DBCommandBase<ClassEntity>
    {
        private ClassEntity _class;

        public SaveClassCommand(ClassEntity classToSave, ISecurityContext context)
        {
            this._class = classToSave;
            //--this._context = context; //--inherit from "IDBCommand"?
        }

        public override ClassEntity Execute(Data.DataConnection.IDBConnection conn)
        {
            ClassEntity classToUpdate = conn.ABETContext.Classes.Where(c => c.ClassId == this._class.ClassId).SingleOrDefault();
            if (classToUpdate != null)
            {
                //this._class.C6opyTo(classToUpdate);
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
