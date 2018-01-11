using ESH.Log.ParserEngine.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESH.Log.ParserEngine.Shared;

namespace ESH.Log.ParserEngine.Handlers
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
