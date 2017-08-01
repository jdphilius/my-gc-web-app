using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoogCalWebApp.Startup))]
namespace GoogCalWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
