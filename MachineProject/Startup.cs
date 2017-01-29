using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MachineProject.Startup))]
namespace MachineProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
