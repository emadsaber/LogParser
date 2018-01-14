using ESH.Log.Parser.Engine.Contracts;
using ESH.Log.Parser.Engine.Services.Reader.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESH.Log.Parser.Engine.Validations.Support;
using ESH.Log.Parser.Engine.Services.Support.Parser;

namespace ESH.Log.Parser.Engine.Services.Parser.Support
{
    public class ParserObject:IValidationTarget
    {
        #region properties
        public List<PlainLine> PlainLines { get; set; }
        #endregion

        #region nested
        public static class MessageFormat
        {
            public static string Format { get; set; }
            public static bool IsIncludingTimeStamp { get; set; }
            public static string TimeStampFormat { get; set; }
            public static bool IsIncludingType { get; set; }
        }
        #endregion
    }
}
