using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_StepByStep.Startup))]
namespace MVC_StepByStep
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
