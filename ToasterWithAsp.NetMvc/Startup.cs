using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToasterWithAsp.NetMvc.Startup))]
namespace ToasterWithAsp.NetMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
