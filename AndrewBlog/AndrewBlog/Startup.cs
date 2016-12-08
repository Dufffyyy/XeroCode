using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AndrewBlog.Startup))]
namespace AndrewBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
