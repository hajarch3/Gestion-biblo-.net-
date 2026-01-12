using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GESTION_BIBLIO.Startup))]
namespace GESTION_BIBLIO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
