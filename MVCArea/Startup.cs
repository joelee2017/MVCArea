using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCArea.Startup))]
namespace MVCArea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
