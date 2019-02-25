using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SINACO_ERP.Startup))]
namespace SINACO_ERP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
