using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(biblioteca.Startup))]
namespace biblioteca
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
