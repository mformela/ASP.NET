using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projectDemo.Startup))]
namespace projectDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
