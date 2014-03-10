using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Model;
using AMI.Data.DatabaseContext;

namespace AMI.Business.Logic.Class
{
    public class SaveClassCommand
        //: IDBCommand<ClassEntity>
    {
        private ClassEntity _class;

        public SaveClassCommand(ClassEntity classToSave, ISecurityContext context)
        {
            this._class = classToSave;
            //--this._context = context; //--inherit from "IDBCommand"?
        }

        //--Override
        public ClassEntity Execute(IABETContext context)
        {
            ClassEntity classToUpdate = context.Classes.Where(c => c.ClassId == this._class.ClassId).SingleOrDefault();
            if (classToUpdate != null)
            {
                //this._class.CopyTo(classToUpdate);
                //context.SaveChanges();
            }
            else
            {
                classToUpdate = this._class;
                context.Classes.Add(this._class);
            }

            return classToUpdate;
        }
    }
}
