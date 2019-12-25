using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ChatAppForm
{
    
    public partial class OnlineBox : UserControl
    {
        Form1 mainForm;

        int nextElementTop;
        delegate void SetTextCallback();
        delegate void addUser(List<string> lista);
        List<string> lista;
        public OnlineBox()
        {
            nextElementTop = 5;
            InitializeComponent();
            this.Height = 0;
        }

        public void setMainForm(Form1 form)
        {
            mainForm = form;
        }
        private void ThreadProcSafe()
        {
            Thread.Sleep(50);
            if (this.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(ClearBox);
                this.Invoke(d);
            }
        }
        private void ThreadProcSafe1()
        {
            Thread.Sleep(50);
            if (this.InvokeRequired)
            {
                addUser d = new addUser(addUserOnline);
                this.Invoke(d, new object[] { this.lista });
            }
        }

        public void AddOnlineUser(List<string> lista)
        {
            this.lista = lista;
            Thread th = new Thread(new ThreadStart(this.ThreadProcSafe1));
            th.Start();
        }

        public void addUserOnline(List<string> lista)
        {
            foreach (string userName in lista)
            {
                OnlineUser user = new OnlineUser(this.mainForm);
                user.SetUserName(userName);

                user.Top = nextElementTop;
                nextElementTop += user.Height;
                this.Height = nextElementTop;
                this.Controls.Add(user);
            }
        }
        public void Clear()
        {
            Thread th = new Thread(new ThreadStart(this.ThreadProcSafe));
            th.Start();  
        }

        public void ClearBox()
        {
            this.Controls.Clear();
            nextElementTop = 5;
        }


    }
}
