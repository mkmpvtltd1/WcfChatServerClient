using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ChatClient
{
    // This is the service contract at client side which uses 
    // the same contract as call back contract.
    // Using CallbackContract, server sends message to clients
    [ServiceContract(CallbackContract = typeof(IChatService))]
    public interface IChatService
    {
        // All operation contracts are one way so that client 
        // can fire the message and forget
        // When server responds, client catches it acts accordingly
        [OperationContract(IsOneWay = true)]
        void Join(string memberName);
        [OperationContract(IsOneWay = true)]
        void Leave(string memberName);
        [OperationContract(IsOneWay = true)]
        void SendMessage(string memberName, string message);
    }

    // An interface to create a channel for communication
    public interface IChatChannel : IChatService, IClientChannel
    {
    }

    public partial class ChatClient : Form, IChatService
    {
        // Different delegates that are used internally to raise 
        // events when client joins,
        // leaves or sends a message
        private delegate void UserJoined(string name);
        private delegate void UserSendMessage(string name, string message);
        private delegate void UserLeft(string name);

        // Events are made static because we want to create only once 
        // when client joins
        private static event UserJoined NewJoin;
        private static event UserSendMessage MessageSent;
        private static event UserLeft RemoveUser;
        //  private IChatChannel ichatchannel;// = null;
        private string userName;
        private IChatChannel channel;
        // As we need to establish duplex communication we use 
        // DuplexChanelFactory

        private DuplexChannelFactory<IChatChannel> factory;

        public ChatClient()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        public ChatClient(string userName)
        {
            this.userName = userName;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                try
                {
                    // Register an event
                    NewJoin += new UserJoined(ChatClient_NewJoin);
                    MessageSent += new UserSendMessage
                        (ChatClient_MessageSent);
                    RemoveUser += new UserLeft(ChatClient_RemoveUser);

                    channel = null;
                    this.userName = txtUserName.Text.Trim();
                    // Create InstanceContext to handle call back interface
                    // Pass the object of the CallbackContract implementor
                    InstanceContext context = new InstanceContext(
                        new ChatClient(txtUserName.Text.Trim()));
                    // We create a participant with the given end point
                    // The communication is managed with CHAT MESH and 
                    // each client creates a duplex 
                    // end point with the mesh. Mesh is nothing but the 
                    // named collection of nodes.
                    factory =
                        new DuplexChannelFactory<IChatChannel>(context, "ChatEndPoint");
                    channel = factory.CreateChannel();
                    channel.Open();
                    channel.Join(this.userName);
                    grpMessageWindow.Enabled = true;
                    grpUserList.Enabled = true;
                    grpUserCredentials.Enabled = false;
                    this.AcceptButton = btnSend;
                    rtbMessages.AppendText
                        ("****WEL-COME to Chat Application*****\r\n");
                    txtSendMessage.Select();
                    txtSendMessage.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        void ChatClient_RemoveUser(string name)
        {
            try
            {
                rtbMessages.AppendText("\r\n");
                rtbMessages.AppendText(name + " left at " +
                        DateTime.Now.ToString());
                lstUsers.Items.Remove(name);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.ToString());
            }
        }

        void ChatClient_MessageSent(string name, string message)
        {
            if (!lstUsers.Items.Contains(name))
            {
                lstUsers.Items.Add(name);
            }
            rtbMessages.AppendText("\r\n");
            rtbMessages.AppendText(name + " says: " + message);
        }

        void ChatClient_NewJoin(string name)
        {
            rtbMessages.AppendText("\r\n");
            rtbMessages.AppendText(name + " joined at:[" + DateTime.Now.ToString() + "]");
            lstUsers.Items.Add(name);
        }

        #region IChatService Members

        public void Join(string memberName)
        {
            if (NewJoin != null)
            {
                NewJoin(memberName);
            }
        }

        public new void Leave(string memberName)
        {
            if (RemoveUser != null)
            {
                RemoveUser(memberName);
            }
        }

        public void SendMessage(string memberName, string message)
        {
            if (MessageSent != null)
            {
                MessageSent(memberName, message);
            }
        }

        #endregion

        private void btnSend_Click(object sender, EventArgs e)
        {
            channel.SendMessage(this.userName, txtSendMessage.Text.Trim());
            txtSendMessage.Clear();
            txtSendMessage.Select();
            txtSendMessage.Focus();
        }

        private void ChatClient_FormClosing(object sender,
                        FormClosingEventArgs e)
        {
            try
            {
                if (channel != null)
                {
                    channel.Leave(this.userName);
                    channel.Close();
                }
                if (factory != null)
                {
                    factory.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        

        
    }
}

