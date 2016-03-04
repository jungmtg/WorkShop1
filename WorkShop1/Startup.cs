using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkShop1.Startup))]
namespace WorkShop1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
