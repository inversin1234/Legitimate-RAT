using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Quasar.Server.Helper;
using Quasar.Server.Messages;
using Quasar.Server.Networking;

namespace Quasar.Server.Forms
{
    public partial class FrmChat : Form
    {
        private readonly Client _connectClient;
        public readonly ChatHandler ChatHandler;
        private static readonly Dictionary<Client, FrmChat> OpenedForms = new Dictionary<Client, FrmChat>();

        public static FrmChat CreateNewOrGetExisting(Client client)
        {
            if (OpenedForms.ContainsKey(client))
            {
                return OpenedForms[client];
            }
            FrmChat f = new FrmChat(client);
            f.Disposed += (sender, args) => OpenedForms.Remove(client);
            OpenedForms.Add(client, f);
            return f;
        }

        public FrmChat(Client client)
        {
            _connectClient = client;
            ChatHandler = new ChatHandler(client);

            RegisterMessageHandler();
            InitializeComponent();
        }

        private void RegisterMessageHandler()
        {
            _connectClient.ClientState += ClientDisconnected;
            ChatHandler.ProgressChanged += ChatOutput;
            MessageHandler.Register(ChatHandler);
        }

        private void UnregisterMessageHandler()
        {
            MessageHandler.Unregister(ChatHandler);
            ChatHandler.ProgressChanged -= ChatOutput;
            _connectClient.ClientState -= ClientDisconnected;
        }

        private void ChatOutput(object sender, string text)
        {
            txtChatOutput.AppendText($"Client: {text}{Environment.NewLine}");
        }

        private void ClientDisconnected(Client client, bool connected)
        {
            if (!connected)
            {
                Invoke((MethodInvoker)Close);
            }
        }

        private void FrmChat_Load(object sender, EventArgs e)
        {
            Text = WindowHelper.GetWindowTitle("Chat", _connectClient);
        }

        private void FrmChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterMessageHandler();
        }

        private void txtChatInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtChatInput.Text))
            {
                ChatHandler.SendMessage(txtChatInput.Text.Trim());
                txtChatOutput.AppendText($"Admin: {txtChatInput.Text.Trim()}{Environment.NewLine}");
                txtChatInput.Clear();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtChatOutput_TextChanged(object sender, EventArgs e)
        {
            NativeMethodsHelper.ScrollToBottom(txtChatOutput.Handle);
        }
    }
}
