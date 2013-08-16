using Microsoft.AspNet.SignalR;
using System;

namespace BasicChat.SelfHost.Hubs
{
    public class Chat : Hub
    {
        public void Send(string message)
        {
            Console.WriteLine("receive and resend message: " + message);

            Clients.All.send(message);
        }
    }
}
