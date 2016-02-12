using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aggressors.Startup))]
namespace Aggressors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
