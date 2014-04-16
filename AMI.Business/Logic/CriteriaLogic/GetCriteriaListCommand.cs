using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.Entity;
using AMI.Data.DataConnection;
using AMI.Model;
using AMI.Model.Filters;

namespace AMI.Business.Logic.CriteriaLogic
{
    public class GetCriteriaListCommand : AsyncDBCommandBase<List<Criteria>>
    {
        public delegate GetCriteriaListCommand Factory(CriteriaFilter filter);

        private CriteriaFilter _filter;

        public GetCriteriaListCommand(CriteriaFilter filter)
        {
            this._filter = filter;
        }

        internal async override Task<List<Criteria>> Execute(IDBConnection conn)
        {
            IQueryable<Criteria> queryable = conn.ABETContext.Criterias;
            if (this._filter != null)
            {
                if (this._filter.Id.HasValue)
                {
                    queryable = queryable.Where(m => m.Id == this._filter.Id.Value);
                }
                if (!string.IsNullOrWhiteSpace(this._filter.Name))
                {
                    queryable = queryable.Where(m => m.Name == this._filter.Name);
                }
            }

            return await queryable.Include(c => c.Outcomes).ToListAsync();
        }
    }
}
