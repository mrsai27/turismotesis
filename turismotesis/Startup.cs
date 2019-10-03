using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(turismotesis.Startup))]
namespace turismotesis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
