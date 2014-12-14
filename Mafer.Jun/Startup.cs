using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mafer.Jun.Startup))]
namespace Mafer.Jun
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
