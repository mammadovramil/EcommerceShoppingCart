using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EcommerceShoppingCart.WebUI.Startup))]
namespace EcommerceShoppingCart.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
