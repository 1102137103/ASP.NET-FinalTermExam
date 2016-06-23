using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_110213710301.Startup))]
namespace _110213710301
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
