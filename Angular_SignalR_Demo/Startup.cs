using Microsoft.Owin;
using Owin;

namespace Angular_SignalR_Demo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
