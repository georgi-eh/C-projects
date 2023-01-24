using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JokesWebApp.Startup))]
namespace JokesWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
