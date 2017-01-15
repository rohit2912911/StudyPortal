using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudyPortal.Startup))]
namespace StudyPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
