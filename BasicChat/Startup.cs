using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;

namespace BasicChat
{
    public class Startup
    {
        // The name *MUST* be Configuration
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll); //has to put before MapSignalR to enable cross domain usage
            app.MapSignalR();
        }
    }
}