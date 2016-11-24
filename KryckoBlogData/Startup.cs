using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KryckoBlogData.Startup))]
namespace KryckoBlogData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
