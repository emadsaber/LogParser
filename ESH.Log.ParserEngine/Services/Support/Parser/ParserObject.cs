using ESH.Log.Parser.Engine.Services.Reader.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Services.Parser.Support
{
    public class ParserObject
    {
        public List<PlainLine> PlainLines { get; set; }
        public string MessageFormat { get; set; }

    }
}
