using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proyecto.MvcNuevo.Startup))]
namespace Proyecto.MvcNuevo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
