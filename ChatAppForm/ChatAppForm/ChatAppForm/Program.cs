using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ChatRoom;

namespace ChatAppForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ChatAPI coreChat = new ChatAPI();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login loginForm = new Login(coreChat);
            loginForm.ShowDialog();
            //Form1 mainForm = new Form1();
            //mainForm.BindChatAPI(coreChat);
            //coreChat.ChatFormWindow = mainForm;
            //mainForm.ShowDialog();
            
            
        }
    }
}
