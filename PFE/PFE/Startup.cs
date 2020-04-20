using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PFE.Startup))]
namespace PFE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
