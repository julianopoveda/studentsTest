using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alunos_Gest_Up.Startup))]
namespace Alunos_Gest_Up
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
