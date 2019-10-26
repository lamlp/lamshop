using System;

namespace LamShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        LamShopDbContext Init();
    }
}