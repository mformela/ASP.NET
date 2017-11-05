using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Impreza.Startup))]
namespace Impreza
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
