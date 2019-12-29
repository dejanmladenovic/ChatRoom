using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ChatRoom;
using System.Threading;

namespace ChatAppForm
{
    delegate void SetTextCallback(ChatRoom.Message message);

    public partial class Form1 : Form, ChatRoom.ChatForm
    {
        ChatAPI chatCore;
        ChatRoom.Message msg;
        public ChatRoom.Color myMessagesColor;

        public Form1()
        {
            InitializeComponent();
            onlineBox.setMainForm(this);
        }


        public void BindChatAPI(ChatAPI chatAPI)
        {
            chatCore = chatAPI;
            
        }

        public void AddOnline(List<string> lista)
        { 
            this.onlineBox.AddOnlineUser(lista);
        }
        public void clearOnlineBox()
        {
            this.onlineBox.Clear();
        }

        private void SetText(ChatRoom.Message msg)
        {

            switch (msg.Type)
            {
                case "user_message":
                    if (chatCore.UserName.Equals(msg.UserName))
                        chatBox.addChatMessage(msg, 0);
                    else
                        chatBox.addChatMessage(msg, 1);
                    break;
                case "user_join":
                    if (chatCore.UserName.Equals(msg.UserName))
                        chatBox.addChatNotification("Uspešno ste se prikljucili ćaskanju kao " + msg.UserName);
                    else
                        chatBox.addChatNotification("Korisnik " + msg.UserName + " se uspešno pridružio ćaskanju.");
                    break;
            }

            
        }


        public void DisplayMessage(ChatRoom.Message message)
        {
            this.msg = message;
            Thread th = new Thread(new ThreadStart(this.ThreadProcSafe));
            th.Start();
       
        }
        public void SendMessage(ChatRoom.Message message)
        {
            chatCore.SendMessage(message);
        }

        private void messageBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(messageBox.Text == "Unesite poruku...")
            {
                messageBox.Text = "";
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            ChatRoom.Message theMessage = new ChatRoom.Message(chatCore.UserName, myMessagesColor, messageBox.Text, "user_message");
            chatCore.SendMessage(theMessage);
            messageBox.Text = "Unesite poruku...";
        }

        private void ThreadProcSafe()
        {
            Thread.Sleep(50);
            if (this.chatBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { msg }) ;
            }
        }



        public void addInMuted(string userName)
        {
            chatCore.addInMutedList(userName);
            chatBox.addChatNotification("Blokirali ste poruke korisnika " + userName + ".");
        }
        public void DeleteFromListMuted(string userName)
        {
            chatCore.DeleteFromListMuted(userName);
            chatBox.addChatNotification("Odobrili ste poruke korisnika " + userName + ".");
        }

        private void messageBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ChatRoom.Message theMessage = new ChatRoom.Message(chatCore.UserName, myMessagesColor, messageBox.Text, "user_message");
                chatCore.SendMessage(theMessage);
                messageBox.Text = "";
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            chatCore.Disconected();
        }
    }
}
