using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityTestProject.Startup))]
namespace IdentityTestProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
