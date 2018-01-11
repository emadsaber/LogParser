using ESH.Log.ParserEngine.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.ParserEngine.Contracts
{
    public interface ILogItem
    {
        string Date { get; set; }
        LogType Type { get; set; }
        string Message { get; set; }
    }
}
