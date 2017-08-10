using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KHBPARedux.Startup))]
namespace KHBPARedux
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
