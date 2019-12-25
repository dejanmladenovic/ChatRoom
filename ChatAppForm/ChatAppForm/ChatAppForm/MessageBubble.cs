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
    public partial class MessageBubble : UserControl
    {
        public MessageBubble()
        {
            InitializeComponent();
            setHeight();
        }

        public MessageBubble(String messageString, String name , DateTime time, ChatRoom.Color messageColor, int msgType)
        {
            InitializeComponent();
            lblUserName.Text = name;
            lblMessage.Text = messageString;

            if(msgType == 0) //in
            {
                this.BackColor = Color.SkyBlue;
            }
            else
            {
                this.BackColor = Color.FromArgb(messageColor.red, messageColor.green, messageColor.blue);
            }
            lblTime.Text = time.ToString();
            setHeight();
        }

        public void setHeight()
        {
            Size maxSize = new Size(500, int.MaxValue);
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(lblMessage.Text, lblMessage.Font, lblMessage.Width);

            lblMessage.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
            lblTime.Top = lblMessage.Bottom + 5;
            this.Height = lblTime.Bottom + 10;

        }

        private void MessageBubble_Resize(object sender, EventArgs e)
        {
            setHeight();
        }
    }
}
