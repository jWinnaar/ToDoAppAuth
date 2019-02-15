using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ToDoAppAuthService.Startup))]

namespace ToDoAppAuthService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}