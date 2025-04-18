using ChartApp.Server.Model;
using Microsoft.AspNetCore.SignalR;

namespace ChartApp.Server.SignalRHub
{
    public class ChartHub : Hub
    {
        public async Task BroadcastChartData(List<Chart> data) =>
       await Clients.All.SendAsync("broadcastchartdata", data);
    }
}
