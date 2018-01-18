using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vogelteller_Web.Startup))]
namespace Vogelteller_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
