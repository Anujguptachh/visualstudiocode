using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Libarary_Management_Code.Startup))]
namespace Libarary_Management_Code
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
//anuj