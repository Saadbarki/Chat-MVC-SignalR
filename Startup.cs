﻿using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(SignalRChat.Startup))]
namespace SignalRChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Configure SignalR here
            app.MapSignalR();
        }
    }
}
