using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Book_WebApp.Startup))]
namespace Book_WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
