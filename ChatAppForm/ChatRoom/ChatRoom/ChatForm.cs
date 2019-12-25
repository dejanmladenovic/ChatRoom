using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    public interface ChatForm
    {
        void DisplayMessage(Message message);
        void SendMessage(Message message);
        void BindChatAPI(ChatAPI chatAPI);
        void AddOnline(List<string> user);

        void clearOnlineBox();
    }
}
