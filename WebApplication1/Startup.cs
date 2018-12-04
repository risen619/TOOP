using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TOOP.Startup))]
namespace TOOP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
