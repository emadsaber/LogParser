using ESH.Log.Parser.Engine.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Services.Support.Parser
{
    public class Message
    {
        public DateTime? TimeStamp { get; set; }
        public LogType Type { get; set; }
        public string TextMessage => this.MessageBuilder?.ToString();  
        public StringBuilder MessageBuilder { get; set; }
    }
}
