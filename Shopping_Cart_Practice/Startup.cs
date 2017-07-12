using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shopping_Cart_Practice.Startup))]
namespace Shopping_Cart_Practice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
