using System.Collections.Generic;
using System.Threading.Tasks;
using AMI.Business.Logic;
using AMI.Data.DataConnection;
using AMI.Model;
using AutoMapper;
using System.Linq;
using AMI.Model.Filters;
using System.Data.Entity;

namespace AMI.Business.Logic.ClassLogic
{
    public class GetClassListCommand : AsyncDBCommandBase<List<Class>>
    {
        private ClassFilter _filter;

        public delegate GetClassListCommand Factory(ClassFilter filter);

        public GetClassListCommand(ClassFilter filter)
        {
            this._filter = filter;
        }

        internal override async Task<List<Class>> Execute(IDBConnection conn)
        {
            IQueryable<Class> classes = conn.ABETContext.Classes;
            if (!string.IsNullOrEmpty(this._filter.Name))
            {
                classes = classes.Where(c => c.Name.Contains(this._filter.Name));
            } 
            if (!string.IsNullOrEmpty(this._filter.Prefix))
            {
                classes = classes.Where(c => c.Prefix.Contains(this._filter.Prefix));
            }
            if (!string.IsNullOrEmpty(this._filter.Number))
            {
                classes = classes.Where(c =>c.Number.Contains(this._filter.Number));
            }

            return await (classes as DbSet<Class>).ToListAsync();
        }
    }
}
