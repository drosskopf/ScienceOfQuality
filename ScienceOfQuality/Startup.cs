using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScienceOfQuality.Startup))]
namespace ScienceOfQuality
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
