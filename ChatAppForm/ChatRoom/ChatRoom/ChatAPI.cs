using StackExchange.Redis;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChatRoom
{
    public class ChatAPI
    {
        private string redisConnectionString;
        private static ConnectionMultiplexer connection = null;
        private static object objLock = new object();
        private string chatChannel;
        private string userName;
        private ChatForm chatForm;
        private ISubscriber pubsub;
        private string nameListUserName;
        private List<string> listMutedUserName;

        public ChatAPI()
        {
            listMutedUserName = new List<string>();
            nameListUserName = "usersList";
            //eksperimentalno sa Singleton
            this.redisConnectionString = "localhost";
            if (connection == null)
            {
                lock (objLock)
                {
                    if (connection == null)
                        connection = ConnectionMultiplexer.Connect(redisConnectionString);
                }
            }
            this.chatChannel = "ChatChannel";
            this.pubsub = connection.GetSubscriber();
            pubsub.Subscribe(chatChannel, (channel, message) => MessageAction(message));
            
        }

        public List<string> ListMutedUserName
        {
            get
            {
                return this.listMutedUserName;
            }
            set
            {
                this.listMutedUserName = value;
            }
        }
        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                this.userName = value;
            }
        }

        public ChatForm ChatFormWindow
        {
            get { return this.chatForm; }
            set
            {
                this.chatForm = value;
            }
        }

        public void SendMessage(Message message)    
        {
            string msg = JsonConvert.SerializeObject(message);
            pubsub.Publish(chatChannel, msg);
        }


        public void addInMutedList(string userName)                       //mutira korisnika, dodaje u listu mutiranih i proverava da li je taj korisnik uopste dostupan
        {
            IDatabase baza = connection.GetDatabase();
            if (ExistsInTheList(baza.ListRange(nameListUserName), userName))
            {
                listMutedUserName.Add(userName);
            }
        }

        public void MessageAction(string message)
        {
            IDatabase baza = connection.GetDatabase();
            Message msg = Newtonsoft.Json.JsonConvert.DeserializeObject<Message>(message);
            if (msg.Type.Equals("login"))
            {

                if (msg.UserName.Equals(this.userName))
                {
                    Message login_notification = new Message("ChatRoom", new Color(144, 144, 144, 0),"", "login_success");
                    List<string> lista = new List<string>();
                    foreach (var el in baza.ListRange(nameListUserName))
                    {
                        if(!this.userName.Equals(el))
                            lista.Add(el.ToString());
                    }
                    chatForm.AddOnline(lista);

                    Message join_notification = new Message(userName, new Color(144, 144, 144, 0), "", "user_join");
                    SendMessage(join_notification);
                }
                else
                {
                    List<string> lista = new List<string>();
                    lista.Add(msg.UserName);
                    chatForm.AddOnline(lista);
                }
            }

            else if (msg.Type.Equals("disconected"))
                {
                    ListMutedUserName.Remove(msg.UserName);
                    chatForm.clearOnlineBox();
                    List<string> lista = new List<string>();
                    foreach (var el in baza.ListRange(nameListUserName))
                    {
                        if(!this.UserName.Equals(el))
                            lista.Add(el.ToString());
                    }
                    chatForm.AddOnline(lista);
                    chatForm.DisplayMessage(new Message("Napustanje grupe :(", new Color(0,0,255,0), "Korisnik " + msg.UserName + " je napustio grupu", "user_disconnected"));
                }
            else if (!ExistsInTheList(listMutedUserName, msg.UserName))             //ako je korisnik koji je mutiran poslao poruku, ne trebamo je prikazati
                 chatForm.DisplayMessage(msg);
        }

        public void DeleteFromListMuted(string userName)            //ukoliko zelimo da odmutiramo korisnika
        {
            listMutedUserName.Remove(userName);
        }

        public bool addUserNameInList(string name)     // prilikom "logovanja" poziva se da bi rigistrovala korisnika, proverava da li je korisnik sa zadatim imenom vec dostupan
        {
            IDatabase baza = connection.GetDatabase();
           
            while (ExistsInTheList(baza.ListRange(nameListUserName), name))
            {
                return false;
            }
            List<string> lista = new List<string>(); 
            
            baza.ListRightPush(nameListUserName, name);

            this.userName = name;
            this.SendMessage(new Message(UserName, new Color(0, 0, 250, 0), "Korisnik " + "'" + UserName + "'" + " se pridruzio grupi", "login"));
          
            return true;
        }
        public bool ExistsInTheList(RedisValue[] lista, string name)   
        {
            
            foreach(var el in lista)
            {
                if (el.ToString().Equals(name))
                    return true;
            }
            return false;
        }

        public bool ExistsInTheList(List<string> lista, string name)
        {
            foreach (string el in lista)
            {
                if (el.ToString().Equals(name))
                    return true;
            }
            return false;
        }


        public void Disconected()                                 //poziva se prilikom napustanja cet sobe, salje poruku tipa disconected da bi se kod ostalih korisnika izbacio iz liste mutiranih, 
        {                                                          //ukoliko je kod nekog korisnika mutiran. Takodje brise svoje korisnicko ime iz liste ulogovanih korisnika
            this.SendMessage(new Message(userName, new Color(255, 0, 0, 0), "", "disconected"));
            IDatabase baza = connection.GetDatabase();
            baza.ListRemove(nameListUserName, userName);
        }
        

    }
}