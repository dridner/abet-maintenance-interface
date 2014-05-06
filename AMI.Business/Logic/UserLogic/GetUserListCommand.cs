using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AMI.Data.DataConnection;
using AMI.Model;
using AMI.Model.Filters;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AMI.Business.Logic.UserLogic
{
    public class GetUserListCommand : AsyncDBCommandBase<List<ApplicationUser>>
    {
        public delegate GetUserListCommand Factory(UserFilter filter);

        private UserFilter _filter;

        public GetUserListCommand(UserFilter filter)
        {
            this._filter = filter;
        }

        internal async override Task<List<ApplicationUser>> Execute(IDBConnection conn)
        {
            IQueryable<ApplicationUser> queryable = conn.UserManager.Users;
            queryable = queryable.Where(m => m.Email != null);//only the system user doesn't have an email address.

            if (this._filter != null)
            {
                //TODO
            }

            queryable = queryable.OrderBy(m => m.FirstName);

            return await queryable.ToListAsync();
        }
    }
}
