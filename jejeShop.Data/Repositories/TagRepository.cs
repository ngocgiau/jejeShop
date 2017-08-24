using jejeShop.Data.Infrastructure;
using jejeShop.Model.Models;

namespace jejeShop.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    { }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}