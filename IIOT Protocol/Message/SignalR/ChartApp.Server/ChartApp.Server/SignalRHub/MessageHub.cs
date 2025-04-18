using ChartApp.Server.Model;
using Microsoft.AspNetCore.SignalR;

namespace ChartApp.Server.SignalRHub
{
    public class MessageHub : Hub
    {

        public async Task SendMessageToAllConnectedUsers(Object msg)
        {
            Console.WriteLine(msg);
            Clients.All.SendAsync($"SendMessageToAllConnectedUsers", new Message("username", "msg", DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss")) { });
        }

        public async Task SendMessageToOtherConnectedUsers(Object msg)
        {
            Console.WriteLine(msg);
            Clients.Others.SendAsync($"SendMessageToOtherClients", msg);
        }

        public async Task SendMessageToGroup(Message msgObj, string groupName)
        {
            Clients.Group(groupName).SendAsync("sendMessageToGroup", msgObj);
            Console.WriteLine($"Message sent to group {groupName}: {msgObj.MessageText} from {msgObj.Username} at {msgObj.Time}.");
        }

        public async Task AddUserToGroup(string groupName)
        {
           await  Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            Console.WriteLine($"User {Context.ConnectionId} added to group {groupName}.");
        }

        public async Task RemoveUserFromGroup(string groupName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
            Console.WriteLine($"User {Context.ConnectionId} removed from group {groupName}.");
        }


        //To Do
        public override Task OnConnectedAsync()
        {
            // Add your own code here.
            // For example: in a chat application, record the association between
            // the current connection ID and user name, and mark the user as online.
            // After the code in this method completes, the client is informed that
            // the connection is established; for example, in a JavaScript client,
            // the start().done callback is executed.
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            // Add your own code here.
            // For example: in a chat application, mark the user as offline, 
            // delete the association between the current connection id and user name.
            return base.OnDisconnectedAsync(exception);
        }

        //public override Task OnReconnected()
        //{
        //    // Add your own code here.
        //    // For example: in a chat application, you might have marked the
        //    // user as offline after a period of inactivity; in that case 
        //    // mark the user as online again.
        //    return base.on();
        //}
    }
}
