using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcRoomBooking.Startup))]
namespace MvcRoomBooking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
