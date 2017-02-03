using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsCiCd.Startup))]
namespace JenkinsCiCd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }   
}
  