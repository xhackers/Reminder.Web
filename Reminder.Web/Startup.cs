using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Reminder.Web.Startup))]
namespace Reminder.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
