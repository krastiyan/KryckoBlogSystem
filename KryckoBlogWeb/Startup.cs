using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KryckoBlogWeb.Startup))]
namespace KryckoBlogWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
