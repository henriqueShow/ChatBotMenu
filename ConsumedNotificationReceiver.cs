using Lime.Protocol;
using System;
using System.Threading;
using System.Threading.Tasks;
using Takenet.MessagingHub.Client.Listener;

namespace ChatBot
{
    public class ConsumedNotificationReceiver : INotificationReceiver
    {
        public async Task ReceiveAsync(Notification notification, CancellationToken cancellationToken)
        {
            // Write the received notification to the console
            Console.WriteLine(notification.ToString());
        }
    }
}
