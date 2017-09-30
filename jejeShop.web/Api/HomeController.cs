using jejeShop.Service;
using jejeShop.Web.Infrastructure.Core;
using System.Web.Http;

namespace jejeShop.Web.Api
{
    [RoutePrefix("api/home")]
    [Authorize]
    public class HomeController : ApiControllerBase
    {
        IErrorService _errorService;

        public HomeController(IErrorService errorService) : base(errorService)
        {
            this._errorService = errorService;
        }

        [HttpGet]
        [Route("TestMethod")]
        public string TestMethod()
        {
            return "hello, welcome to jejeshop. ";
        }
    }
}