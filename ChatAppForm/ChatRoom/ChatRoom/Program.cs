using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    public class Program : ChatForm
    {

        private ChatAPI API;
       

        public Program()
        {
            API = new ChatAPI();

        }
        public void BindChatAPI(ChatAPI chatAPI)
        {
            API = chatAPI;
        }

        public void DisplayMessage(Message message)
        {
            Console.WriteLine(message.MessageValue);
        }

        public void SendMessage(Message message)
        {
            API.SendMessage(message);
        }


        static void Main()
        {
            Program prog = new Program();
            Console.WriteLine("Koga zelite da blokirate");
            prog.API.addInMutedList(Console.ReadLine());
            while (true)
            {
               
                string unos = Console.ReadLine();
                prog.SendMessage(new Message(prog.API.UserName, new Color(255, 0, 0, 0), unos, ""));
                if (unos.Equals("Close"))
                {
                    prog.API.Disconected();   
                    return;
                }

            }
        }

        public void AddOnline(List<string> user)
        {
            throw new NotImplementedException();
        }

        public void clearOnlineBox()
        {
            throw new NotImplementedException();
        }
    }
}
