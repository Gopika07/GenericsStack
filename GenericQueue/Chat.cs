using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueue
{
    public class Chat
    {
        public string Content {  get; set; }
        public int MessageId { get; set; }
        public DateTime TimeStamp { get; set; }
        public int SourceID { get; set; }

        public Chat(string content, int messageId, DateTime timeStamp, int sourceId)
        {
            Content = content;
            MessageId = messageId;
            TimeStamp = timeStamp;
            SourceID = sourceId;
        }
    }
}
