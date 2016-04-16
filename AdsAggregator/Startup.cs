using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdsAggregator.Startup))]
namespace AdsAggregator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
