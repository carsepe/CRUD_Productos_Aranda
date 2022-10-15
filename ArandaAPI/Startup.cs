using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using ArandaLogicaNegocio.Dotos;

[assembly: OwinStartup(typeof(ArandaAPI.Startup))]

namespace ArandaAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(ArandaContext.Create);
        }
    }
}
