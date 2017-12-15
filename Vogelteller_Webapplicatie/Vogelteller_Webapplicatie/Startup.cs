using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vogelteller_Webapplicatie.Startup))]
namespace Vogelteller_Webapplicatie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
