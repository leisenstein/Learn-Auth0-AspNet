using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Learn_Auth0_AspNet.Startup))]
namespace Learn_Auth0_AspNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
