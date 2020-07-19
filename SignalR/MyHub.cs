using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR
{
    [HubName("HubMessage")]
    public class MyHub : Hub
    {
        public void SendMessage(string remetente, string destinatario, string message)
        {
            Clients.All.messageAdded(remetente, destinatario, message);
        }
        
        public void SendMessageOfficial(string name,string mensagem)
        {
            Clients.All.messageOfficial(name, mensagem);
        }
    }
}