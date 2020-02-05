using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHub_2.Startup))]
namespace GigHub_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
