using jejeShop.Data.Infrastructure;
using jejeShop.Model.Models;

namespace jejeShop.Data.Repositories
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbfactory)
            : base(dbfactory)
        {
        }
    }
}