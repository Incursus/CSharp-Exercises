using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JavaScriptIncludeFileFromAsp.net.Startup))]
namespace JavaScriptIncludeFileFromAsp.net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
