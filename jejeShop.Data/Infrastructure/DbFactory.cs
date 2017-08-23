namespace jejeShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private jejeShopDbContext dbContext;

        public jejeShopDbContext Init()
        {
            return dbContext ?? (dbContext = new jejeShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}