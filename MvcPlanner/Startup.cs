using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPlanner.Startup))]
namespace MvcPlanner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
