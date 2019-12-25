using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppForm
{
    public partial class OnlineUser : UserControl
    {
        
        Form1 mainForm;
        public OnlineUser(Form1 forma)
        {
            InitializeComponent();
            mainForm = forma;
        }

        public void SetUserName(string user)
        {
            this.lblUserName.Text = user;
        }

        private void chxBoxMuted_CheckedChanged(object sender, EventArgs e)
        {
            if(chxBoxMuted.Checked == true)
            {
                mainForm.addInMuted(this.lblUserName.Text);
            }
            else
            {
                mainForm.DeleteFromListMuted(this.lblUserName.Text);
            }
        }
    }
}
