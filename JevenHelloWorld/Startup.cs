using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JevenHelloWorld.Startup))]
namespace JevenHelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
