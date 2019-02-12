using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(softwareScocietyIiui.Startup))]
namespace softwareScocietyIiui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
