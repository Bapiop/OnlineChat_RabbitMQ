using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OnlineChat_RabbitMQ
{
    public partial class LoginUI : UserControl
    {
        public event EventHandler<string> onLogin;
        MySQL_Connection MySQL_Connection = new MySQL_Connection();
        MySqlCommand MySQL_Command;
        MySqlDataAdapter MySQL_DataAdapter;
        DataTable MySQL_DataTable;

        public LoginUI()
        {
            InitializeComponent();
            MySQL_Connection.Connect();
        }

        private void userLogin_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySQL_Connection.cn.Open();
                MySQL_Command = new MySqlCommand(String.Format("SELECT * FROM users WHERE username=\"{0}\" AND password=\"{1}\"", oy_textBox1.Text, oy_textBox2.Text), MySQL_Connection.cn);
                MySQL_Command.ExecuteNonQuery();
                MySQL_DataTable = new DataTable();
                MySQL_DataAdapter = new MySqlDataAdapter(MySQL_Command);
                MySQL_DataAdapter.Fill(MySQL_DataTable); 
                
                if(MySQL_DataTable.Rows[0] != null)
                {
                    onLogin?.Invoke(this, oy_textBox1.Text);
                    MainForm.Instance.Content.Controls[0].SendToBack();
                }
                MySQL_Connection.cn.Close();
            }
            catch (Exception ex)
            {
                MySQL_Connection.cn.Close();
                MessageBox.Show("Incorrect user. Try again");
            }
            
        }
    }
}
