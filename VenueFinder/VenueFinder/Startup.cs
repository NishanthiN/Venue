using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VenueFinder.Startup))]
namespace VenueFinder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
