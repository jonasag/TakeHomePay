using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TakeHomePay.Website.Startup))]
namespace TakeHomePay.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
