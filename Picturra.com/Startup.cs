using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Picturra.com.Startup))]
namespace Picturra.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            Bootstrapper.Initialize();
        }
    }
}
