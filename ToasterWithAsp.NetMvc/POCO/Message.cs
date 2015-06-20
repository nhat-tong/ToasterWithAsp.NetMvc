using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToasterWithAsp.NetMvc.POCO
{
    public class Message
    {
        public const string Key = "Message";

        public string Content { get; set; }

        public MessageType MessageType { get; set; }

        public Message()
        {
            this.Content = string.Empty;
            this.MessageType = MessageType.Info;
        }

        public Message(string content, MessageType messageType)
        {
            this.Content = content;
            this.MessageType = messageType;
        }
    }
}
