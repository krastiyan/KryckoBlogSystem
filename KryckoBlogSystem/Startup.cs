using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KryckoBlogSystem.Startup))]
namespace KryckoBlogSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
