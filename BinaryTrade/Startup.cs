using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BinaryTrade.Startup))]
namespace BinaryTrade
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
