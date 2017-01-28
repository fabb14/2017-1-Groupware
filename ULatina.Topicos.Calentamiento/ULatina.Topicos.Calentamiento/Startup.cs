using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ULatina.Topicos.Calentamiento.Startup))]
namespace ULatina.Topicos.Calentamiento
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
