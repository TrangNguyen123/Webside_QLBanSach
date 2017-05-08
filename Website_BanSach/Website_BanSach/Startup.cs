using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Website_BanSach.Startup))]
namespace Website_BanSach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
