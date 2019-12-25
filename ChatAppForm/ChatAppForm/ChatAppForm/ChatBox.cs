using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatRoom;

namespace ChatAppForm
{
    public partial class ChatBox : UserControl
    {
        int nextElementTop;
        public ChatBox()
        {
            nextElementTop = 5;
            InitializeComponent();
            this.Height = 0;
            //messagesPanel.Width = this.Width;
            //messagesPanel.Top = 0;
        }

        public void addChatMessage(ChatRoom.Message message, int msgType) 
        {
            MessageBubble bubble = new MessageBubble(message.MessageValue, message.UserName , message.DateTime, message.MessageColor ,msgType);
            if(msgType == 0)
            {
                bubble.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                bubble.Left = this.Width - bubble.Width - 5;
            }
            else
            {
                bubble.Left = this.Left + 5;
            }
            bubble.Top = nextElementTop;
            nextElementTop += bubble.Height + 10;
            this.Height = nextElementTop;
            this.Controls.Add(bubble);
        }
    }
}
