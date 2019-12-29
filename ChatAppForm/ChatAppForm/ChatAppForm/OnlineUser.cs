using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace ChatAppForm
{
    public partial class OnlineUser : UserControl
    {
        bool userMuted;
        Form1 mainForm;
        public OnlineUser(Form1 forma)
        {
            InitializeComponent();
            mainForm = forma;
            userMuted = false;
        }

        public void SetUserName(string user)
        {
            this.lblUserName.Text = user;
        }

        

        private void soundIcon_Click(object sender, EventArgs e)
        {
            if (userMuted)
            {
                mainForm.DeleteFromListMuted(this.lblUserName.Text);
                userMuted = false;
                soundIcon.Image = ChatAppForm.Properties.Resources.sound;
            }
            else
            {
                mainForm.addInMuted(this.lblUserName.Text);
                userMuted = true;
                soundIcon.Image = ChatAppForm.Properties.Resources.mute;
            }
        }
    }
}
