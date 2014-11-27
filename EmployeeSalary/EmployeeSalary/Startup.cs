using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeSalary.Startup))]
namespace EmployeeSalary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
