using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TelemagicWorkflow.Startup))]
namespace TelemagicWorkflow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
