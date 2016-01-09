using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GuitarCenterWebSite.Startup))]
namespace GuitarCenterWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
