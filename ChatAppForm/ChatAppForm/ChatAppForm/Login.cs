using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatRoom;

namespace ChatAppForm
{
    public partial class Login : Form
    {
        ChatAPI coreChat;
        Form1 mainForm;
        public Login(ChatAPI api)
        {
            coreChat = api;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (coreChat.addUserNameInList(tbUserName.Text))
            {
                //this.DialogResult = System.Windows.Forms.DialogResult.No;
                //mainForm.AddOnline(tbUserName.Text);
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username je zauzet.Pokusajte ponovo.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            mainForm = new Form1();
            mainForm.BindChatAPI(coreChat);
            coreChat.ChatFormWindow = mainForm;           
        }
    }
}
