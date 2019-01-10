using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MobileCan.Startup))]
namespace MobileCan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
