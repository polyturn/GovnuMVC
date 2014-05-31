using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GovnuMVC.Startup))]
namespace GovnuMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
