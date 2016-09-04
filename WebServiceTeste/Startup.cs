using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebServiceTeste.Startup))]
namespace WebServiceTeste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
