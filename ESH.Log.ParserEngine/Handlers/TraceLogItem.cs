using ESH.Log.Parser.Engine.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESH.Log.Parser.Engine.Shared;

namespace ESH.Log.Parser.Engine.Handlers
{
    public class TraceLogItem : ILogItem
    {
        #region properties
        public string Date { get; set; }
        public LogType Type { get; set; }
        public string Message { get; set; }
        #endregion

        #region constructors
        public TraceLogItem()
        {
            this.Type = LogType.Trace;
        }
        #endregion
    }
}
