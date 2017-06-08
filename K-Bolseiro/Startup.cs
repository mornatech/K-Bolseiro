using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(K_Bolseiro.Startup))]
namespace K_Bolseiro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
