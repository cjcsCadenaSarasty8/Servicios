using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Servicios.Startup))]
namespace Servicios
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
