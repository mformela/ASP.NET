using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZaproszenieImprezaGotowiec.Startup))]
namespace ZaproszenieImprezaGotowiec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
