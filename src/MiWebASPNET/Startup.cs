using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiWebASPNET.Startup))]
namespace MiWebASPNET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
