using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityTest_Dev.Startup))]
namespace IdentityTest_Dev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
