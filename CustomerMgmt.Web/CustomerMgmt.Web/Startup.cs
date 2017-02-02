using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerMgmt.Web.Startup))]
namespace CustomerMgmt.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
