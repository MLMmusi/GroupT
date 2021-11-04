using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroupT.Startup))]
namespace GroupT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
