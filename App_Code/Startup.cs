using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quan_li_ve_so.Startup))]
namespace Quan_li_ve_so
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
