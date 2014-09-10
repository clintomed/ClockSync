using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;



namespace ClockSync
{
    public class TimeHub : Hub
    {
        public void Sync(string name, float timeInMilliseconds)
        {
            DateTime now = DateTime.Now;
            float newTime = (now.Millisecond + timeInMilliseconds) / 2;
            //Calling a method to update the client's clocks
            Clients.All.broadcastTime(name, newTime);

        }
    }
}