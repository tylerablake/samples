using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Walkthrough.Startup))]
namespace Walkthrough
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
