using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jejeShop.web.Startup))]
namespace jejeShop.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
