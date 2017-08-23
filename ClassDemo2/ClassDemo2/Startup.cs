using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassDemo2.Startup))]
namespace ClassDemo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
