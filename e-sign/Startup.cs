using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(e_sign.Startup))]
namespace e_sign
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
