using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetctTest.Startup))]
namespace ProjetctTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
