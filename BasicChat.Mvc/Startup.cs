using Owin;

namespace BasicChat.Mvc
{
    public class Startup
    {
        // The name *MUST* be Configuration
        public void Configuration(IAppBuilder app)
        {
            app.MapHubs();
        }
    }
}