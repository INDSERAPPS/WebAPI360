using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAPI360_Web.Startup))]
namespace WebAPI360_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
