using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassDemo.Startup))]
namespace ClassDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
