using System;

namespace CustomerMgmt.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        CustomerEntities Init();
    }
}