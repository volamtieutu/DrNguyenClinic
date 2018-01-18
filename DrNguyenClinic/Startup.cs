using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DrNguyenClinic.Startup))]
namespace DrNguyenClinic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
