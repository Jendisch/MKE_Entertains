using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MKEntertains.Startup))]
namespace MKEntertains
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
