using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewProjectAction.Startup))]
namespace NewProjectAction
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
