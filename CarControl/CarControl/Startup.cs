using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarControl.Startup))]
namespace CarControl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
