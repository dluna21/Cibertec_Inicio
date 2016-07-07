using LightInject;
using Microsoft.Owin;
using Owin;
using System.Reflection;
using Webdeveloper.DataAccess;
using WebDeveloper.Model;

[assembly: OwinStartupAttribute(typeof(WebDeveloper.Startup))]
namespace WebDeveloper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //todos los contenedores deben implementorse un sola vez
            //patron facade contenedeor de constructores idea de los injectores de dependencia.
            ConfigureAuth(app);
            var container = new ServiceContainer();
            container.RegisterAssembly(Assembly.GetExecutingAssembly());
            container.RegisterAssembly("WebDeveloper.*.dll");
            container.RegisterControllers();
            container.EnableMvc();
        }
    }
}
