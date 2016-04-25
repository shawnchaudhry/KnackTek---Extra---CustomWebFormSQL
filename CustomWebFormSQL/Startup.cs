using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomWebFormSQL.Startup))]
namespace CustomWebFormSQL
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
