using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FixGitMVC.Startup))]
namespace FixGitMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
