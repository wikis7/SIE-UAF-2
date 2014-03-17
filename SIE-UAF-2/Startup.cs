using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIE_UAF_2.Startup))]
namespace SIE_UAF_2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
