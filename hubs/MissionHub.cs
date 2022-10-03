using masroufiServer.models;
using Microsoft.AspNetCore.SignalR;
namespace masroufiServer.hubs
{
    public class MissionHub : Hub
     {
        public async Task SendOffersToUser(String msg)
        {
            await Clients.All.SendAsync(msg);
        }
    }
}
