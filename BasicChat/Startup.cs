using Microsoft.AspNet.SignalR;
using Owin;

namespace BasicChat
{
    public class Startup
    {
        // The name *MUST* be Configuration
        public void Configuration(IAppBuilder app)
        {
            var config = new HubConfiguration
            {
                EnableCrossDomain = true
            };

            app.MapHubs(config);
        }
    }
}