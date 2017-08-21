using System;
using System.Threading;
using System.Threading.Tasks;
using Lime.Protocol;
using Takenet.MessagingHub.Client;
using Takenet.MessagingHub.Client.Listener;
using Takenet.MessagingHub.Client.Sender;
using System.Diagnostics;

namespace ChatBot
{
    public class PlainTextMessageReceiver : IMessageReceiver
    {
        private readonly IMessagingHubSender _sender;

        public PlainTextMessageReceiver(IMessagingHubSender sender)
        {
            _sender = sender;
        }

        public async Task ReceiveAsync(Message message, CancellationToken cancellationToken)
        {
            //Trace.TraceInformation($"From: {message.From} \tContent: {message.Content}");
            //await _sender.SendMessageAsync("Pong!", message.From, cancellationToken);

            // Write the received message to the console
            Console.WriteLine(message.Content.ToString());
            // Responds to the received message
            await _sender.SendMessageAsync("Hi. I just received your message!", message.From, cancellationToken);
        }
    }
}
