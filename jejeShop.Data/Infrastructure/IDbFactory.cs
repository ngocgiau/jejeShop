using System;

namespace jejeShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        jejeShopDbContext Init();
    }
}