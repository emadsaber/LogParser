﻿using ESH.Log.Parser.Engine.Contracts;
using ESH.Log.Parser.Engine.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Handlers
{
    public class InfoLogItem : ILogItem
    {
        #region properties
        public string Date { get; set; }
        public LogType Type { get; set; }
        public string Message { get; set; }
        #endregion

        #region constructors
        public InfoLogItem()
        {
            this.Type = LogType.Info;
        }
        #endregion
    }
}
