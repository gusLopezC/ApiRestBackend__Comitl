using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Monitoreo.UI.WebBackend.Startup))]
namespace Monitoreo.UI.WebBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
