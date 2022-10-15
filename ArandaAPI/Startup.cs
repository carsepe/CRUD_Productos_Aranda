using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using ArandaLogicaNegocio.Dotos;


namespace ArandaAPI
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext(ArandaContext.Create);
        }
    }
}
