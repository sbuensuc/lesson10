using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lesson10.Startup))]
namespace lesson10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
