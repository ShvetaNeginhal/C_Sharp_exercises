using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MegaOnlineStore.Startup))]
namespace MegaOnlineStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
