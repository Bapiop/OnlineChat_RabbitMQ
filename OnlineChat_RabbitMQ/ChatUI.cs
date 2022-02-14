using MySql.Data.MySqlClient;
using Newtonsoft.Json;
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

namespace OnlineChat_RabbitMQ
{
    public partial class ChatUI : UserControl
    {
        public event EventHandler<string> SendMassageHandler;
        public event EventHandler<string> SelectChatHandler;

        private string CurrentLogin;
        public string CurrentUserName
        {
            get { return CurrentLogin; }
            set { CurrentLogin = value; }
        }
        
        public string CurrentUserLogin;
        MySQL_Connection MySQL_Connection = new MySQL_Connection();
        MySqlCommand MySQL_Command;
        MySqlDataAdapter MySQL_DataAdapter;
        DataTable MySQL_DataTable;

        private const int EM_SETCUEBANNER = 0x1501;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        public ChatUI(string CurrentUserLogin)
        {
            InitializeComponent();
            oy_textBox1.GotFocus += onFocus;
            oy_textBox1.LostFocus += onDefocus;
            CurrentLogin = CurrentUserLogin;
            MySQL_Connection.Connect();
        }
        public void onFocus(object sender, EventArgs e)
        {
            if (oy_textBox1.Text == "...text to...")
            {
                oy_textBox1.Text = "";
            }
        }
        public void onDefocus(object sender, EventArgs e)
        {
            if (oy_textBox1.Text == "")
            {
                oy_textBox1.Text = "...text to...";
            }
        }
        private void userChat_Load(object sender, EventArgs e)
        {
            oy_button3.Enabled = false;
            oy_listBox1.Visible = false;
            oy_textBox1.Visible = false;
            oy_listBox1.Items.Clear();
            try
            {
                MySQL_Connection.cn.Open();
                MySQL_Command = new MySqlCommand(string.Format("SELECT username FROM users WHERE username!=\"{0}\"", CurrentLogin), MySQL_Connection.cn);
                MySQL_Command.ExecuteNonQuery();
                MySQL_DataAdapter = new MySqlDataAdapter(MySQL_Command);
                MySQL_DataTable = new DataTable();
                MySQL_DataAdapter.Fill(MySQL_DataTable);
                foreach (DataRow dr in MySQL_DataTable.Rows)
                {
                    oy_listView1.Items.Add(dr[0].ToString());
                }
                MySQL_Connection.cn.Close();
            }
            catch (Exception ex)
            {
                MySQL_Connection.cn.Close();
                MessageBox.Show(ex.Message);
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(oy_textBox1.Text!= "...text to...")
            {
            SendMassageHandler?.Invoke(this, oy_textBox1.Text);
            oy_textBox1.Text = "...text to...";
            }
        }

        public void ReceiveMessage(Message message, string currentSelectedChat)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                if(message.Author == currentSelectedChat || message.Author == CurrentLogin)
                {
                oy_listBox1.Items.Add(message.Author + ": " + Encoding.UTF8.GetString(message.Text,0, message.Text.Length));

                }
            }));
        }

        public void LoadMessageHistory(string chatName)
        {
            MySqlDataReader reader = MySQL_Connection.LoadMessageHistory(chatName);
            while (reader.Read())
            {
                Message message = JsonConvert.DeserializeObject<Message>(reader.GetString(0));
                oy_listBox1.Items.Add(message.Author + ": " + Encoding.UTF8.GetString(message.Text, 0, message.Text.Length));
            }



        }


        public void ClearChat()
        {
            oy_listBox1.Items.Clear();
        }

        public void EnableSendButton()
        {
            oy_button3.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(oy_listView1.SelectedItems.Count != 0)
            {
            oy_listBox1.Visible = true;
            oy_textBox1.Visible = true;
            SelectChatHandler?.Invoke(this, oy_listView1.SelectedItems[oy_listView1.SelectedItems.Count - 1].Text);
            }
        }
    }
}
