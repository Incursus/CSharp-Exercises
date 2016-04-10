using System;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspDotNetTest.Startup))]
namespace AspDotNetTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            Console.WriteLine("Test");
        }
    }
}
