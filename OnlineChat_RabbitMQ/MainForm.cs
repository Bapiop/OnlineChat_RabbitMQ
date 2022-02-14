using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace OnlineChat_RabbitMQ
{
    public partial class MainForm : Form
    {
        private static MainForm _instance;
        public static MainForm Instance
        {
            get { 
                if( _instance == null )
                    _instance = new MainForm();
                return _instance;
            }
        }

        // RabbitMQ Sender / Receiver
        private Sender RabbitMQ_Sender = null;
        private Receiver RabbitMQ_Receiver = null;

        // LoginUI / ChatUI
        private LoginUI LoginUI_Username = null;
        private ChatUI ChatUI_MassageChat = null;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private string CurrentUser;
        private string CurrentChat;
        private string CurrentLoggedUser;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public MainForm()
        {
            InitializeComponent();
        }

        public Panel Content
        {
            get { return oy_mainContainer; }
            set { oy_mainContainer = value; }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            _instance = this;
            LoginUI_Username = new LoginUI();
            oy_mainContainer.Controls.Add(LoginUI_Username);
            LoginUI_Username.onLogin += HandleLogin;
            oy_MenuHeader.BackColor = Color.FromArgb(128, 128, 128);
        }

        private void HandleLogin(object sender, string username)
        {
            CurrentUser = username;
            ChatUI_MassageChat = new ChatUI(username);
            oy_mainContainer.Controls.Add(ChatUI_MassageChat);
            ChatUI_MassageChat.SendMassageHandler += HandleMessageSend;
            ChatUI_MassageChat.SelectChatHandler += HandleChatSelection;
            RabbitMQ_Sender = new Sender(username);
            RabbitMQ_Receiver = new Receiver(username);
            RabbitMQ_Receiver.onMessageReceived += HandleMessageReceived;
            oy_label1.Text = CurrentUser;
        }

        private void HandleChatSelection(object sender, string selectedChat)
        {
            ChatUI_MassageChat.EnableSendButton();
            ChatUI_MassageChat.ClearChat();
            string oy_ChatName = string.Empty;
            if(!MySQL_Connection.DoesChatExist(CurrentUser, selectedChat, out oy_ChatName))
            {
                oy_ChatName = MySQL_Connection.CreateChatRoom(CurrentUser, selectedChat);
            }
            if(oy_ChatName !=null)
            {
                ChatUI_MassageChat.LoadMessageHistory(oy_ChatName);
            }
            RabbitMQUtility.DeclareQueueExchange(RabbitMQ_Sender.Channel, oy_ChatName, "fanout");
            RabbitMQUtility.BindExchangeToQueue(RabbitMQ_Sender.Channel, oy_ChatName, RabbitMQ_Sender.User);
            CurrentChat = oy_ChatName;
            CurrentLoggedUser = selectedChat;
            oy_label2.Text = selectedChat;
            
        }

        private void HandleMessageSend(object sender, string messageText)
        {
            RabbitMQ_Sender.SendMessage(messageText, CurrentChat);
        }

        private void HandleMessageReceived(object sender, Message message)
        {
            ChatUI_MassageChat.ReceiveMessage(message, CurrentLoggedUser);
        }

        private void onlineChatMenuStrip_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void onlineChatMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void onlineChatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oy_mainContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
