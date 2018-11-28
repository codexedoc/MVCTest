using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(githubTest.Startup))]
namespace githubTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
