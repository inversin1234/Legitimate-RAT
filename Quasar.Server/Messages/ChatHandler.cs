using Quasar.Common.Messages;
using Quasar.Common.Networking;
using Quasar.Server.Networking;

namespace Quasar.Server.Messages
{
    /// <summary>
    /// Handles messages for the chat communication with a client.
    /// </summary>
    public class ChatHandler : MessageProcessorBase<string>
    {
        private readonly Client _client;

        public ChatHandler(Client client) : base(true)
        {
            _client = client;
        }

        public override bool CanExecute(IMessage message) => message is ChatMessage;

        public override bool CanExecuteFrom(ISender sender) => _client.Equals(sender);

        public override void Execute(ISender sender, IMessage message)
        {
            if (message is ChatMessage chat && chat.FromClient)
            {
                OnReport(chat.Text);
            }
        }

        /// <summary>
        /// Sends a chat message to the client.
        /// </summary>
        /// <param name="text">The message text.</param>
        public void SendMessage(string text)
        {
            _client.Send(new ChatMessage { FromClient = false, Text = text });
        }
    }
}
