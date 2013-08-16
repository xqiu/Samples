using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;

namespace OtherSamples
{
    public class Startup
    {
        // This method name is important
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }
}
