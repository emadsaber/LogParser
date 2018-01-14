using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Shared
{
    public enum LogType
    {
        Trace = 0,
        Info = 1,
        Warning = 2,
        Error = 3
    }
    public enum FieldType
    {
        Text = 100,
        Date = 200, 
        LogType = 300,
    }
}
