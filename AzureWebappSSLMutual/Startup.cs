using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureWebappSSLMutual.Startup))]
namespace AzureWebappSSLMutual
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
