using ESH.Log.Parser.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Services.Support.Parser
{
    public class MessageFormat
    {
        public MessageFormat()
        {
            this.FullFormat = AppResources.Parser_Foramt_DefaultFormat;
            this.IsIncludingTimeStamp = true;
            this.TimeStampFormat = AppResources.DefaultTimeStampFormat;
            this.IsIncludingType = true;
        }
        public string FullFormat { get; set; } 
        public bool IsIncludingTimeStamp { get; set; }
        public string TimeStampFormat { get; set; } 
        public bool IsIncludingType { get; set; }
    }
}
