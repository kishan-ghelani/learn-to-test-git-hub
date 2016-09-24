using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(firstgreetingcard.Startup))]
namespace firstgreetingcard
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
