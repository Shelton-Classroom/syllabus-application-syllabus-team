using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SyllaBest.Startup))]
namespace SyllaBest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
