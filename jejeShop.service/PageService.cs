using jejeShop.Data.Infrastructure;
using jejeShop.Data.Repositories;
using jejeShop.Model.Models;

namespace jejeShop.Service
{
    public interface IPageService
    {
        Page GetByAlias(string alias);
    }
    public class PageService : IPageService
    {
        IpageRepository _pageRepository;
        IUnitOfWork _unitOfWork;
        public PageService(IpageRepository pageRepository, IUnitOfWork unitOfWork)
        {
            this._pageRepository = pageRepository;
            this._unitOfWork = unitOfWork;
        }
        public Page GetByAlias(string alias)
        {
            return _pageRepository.GetSingleByCondition(x => x.Alias == alias);
        }
    }
}