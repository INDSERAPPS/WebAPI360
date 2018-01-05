using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAPI360Management_Web.Startup))]
namespace WebAPI360Management_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
