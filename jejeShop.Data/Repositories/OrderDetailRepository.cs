using jejeShop.Data.Infrastructure;
using jejeShop.Model.Models;

namespace jejeShop.Data.Repositories
{
    public interface IOrderDetailReposirory : IRepository<OrderDetail>
    {
    }

    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailReposirory
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
         { }
    }
}