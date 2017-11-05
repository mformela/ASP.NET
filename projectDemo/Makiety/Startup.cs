using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Makiety.Startup))]
namespace Makiety
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
