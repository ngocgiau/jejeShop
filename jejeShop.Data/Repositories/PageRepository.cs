using jejeShop.Data.Infrastructure;
using jejeShop.Model.Models;

namespace jejeShop.Data.Repositories
{
    public interface IpageRepository : IRepository<Page>
    { }

    public class PageRepository : RepositoryBase<Page>, IpageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}