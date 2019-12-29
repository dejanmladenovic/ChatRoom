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
        System.Drawing.Color myColor;
        public Login(ChatAPI api)
        {
            coreChat = api;
            myColor = System.Drawing.Color.SkyBlue;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text == "")
            {
                MessageBox.Show("Morate uneti korisničko ime.");
                return;
            }
            if (coreChat.addUserNameInList(tbUserName.Text))
            {
                this.Hide();
                mainForm.myMessagesColor = new ChatRoom.Color(255, myColor.R, myColor.G, myColor.B);
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Korisničko ime je zauzeto. Pokušajte ponovo.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            mainForm = new Form1();
            mainForm.BindChatAPI(coreChat);
            coreChat.ChatFormWindow = mainForm;           
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColorPicker.BackColor = colorDialog.Color;
                myColor = colorDialog.Color;
            }
        }
    }
}
