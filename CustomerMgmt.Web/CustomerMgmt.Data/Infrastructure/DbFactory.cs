using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerMgmt.Data.Infrastructure
{
    public class DbFactory: IDbFactory
    {
        public CustomerEntities dbContext;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public CustomerEntities Init()
        {
            return dbContext ?? (dbContext = new CustomerEntities());
        }

       }
}