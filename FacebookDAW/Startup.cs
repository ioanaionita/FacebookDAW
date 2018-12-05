using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacebookDAW.Startup))]
namespace FacebookDAW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
