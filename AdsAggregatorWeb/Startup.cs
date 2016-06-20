using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdsAggregatorWeb.Startup))]
namespace AdsAggregatorWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
