﻿using ESH.Log.Parser.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Services.Support.Parser
{
    public class MessageFormat
    {
        public string FullFormat { get; set; } = AppResources.Parser_Foramt_DefaultFormat;
        public bool IsIncludingTimeStamp { get; set; }
        public string TimeStampFormat { get; set; } = AppResources.DefaultTimeStampFormat;
        public bool IsIncludingType { get; set; }
    }
}
