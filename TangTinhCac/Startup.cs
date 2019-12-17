using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TangTinhCac.Startup))]
namespace TangTinhCac
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
