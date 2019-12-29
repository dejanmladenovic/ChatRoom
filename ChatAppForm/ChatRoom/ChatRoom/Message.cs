using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChatRoom
{
    public class Message
    {
        string userName;
        Color messageColor;
        string messageValue;
        DateTime dateTime;
        string type;
        string pictureUrl;

        public Message()
        {
            this.userName = "";
            this.messageColor = new ChatRoom.Color(255, 255, 0, 0);
            this.messageValue = "";
            this.dateTime = System.DateTime.Now;
            this.type = "";
            this.pictureUrl = "";
        }

        public Message(string name, Color color, string message, string type)
        {
            this.userName = name;
            this.messageColor = color;
            this.messageValue = message;
            this.dateTime = System.DateTime.Now;
            this.type = type;
            this.pictureUrl = "";
        }

        public Message(string name, Color color, string message, string type, string pictureUrl)
        {
            this.userName = name;
            this.messageColor = color;
            this.messageValue = message;
            this.dateTime = System.DateTime.Now;
            this.type = type;
            this.pictureUrl = pictureUrl;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
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
        public Color MessageColor
        {
            get
            {
                return this.messageColor;
            }
            set
            {
                this.messageColor = value;
            }
        }
        public string MessageValue
        {
            get
            {
                return this.messageValue;
            }
            set
            {
                this.messageValue = value;
            }
        }
        public DateTime DateTime
        {
            get
            {
                return this.dateTime;
            }
            set
            {
                this.dateTime = value;
            }
        }

        public string PictureUrl
        {
            get
            {
                return this.pictureUrl;
            }
            set
            {
                this.pictureUrl = value;
            }
        }

    }

    public struct Color
    {
        public byte alpha;
        public byte red;
        public byte blue;
        public byte green;

        public Color(byte a, byte r, byte g, byte b)
        {
            alpha = a;
            red = r;
            green = g;
            blue = b;
        }
    }
}
