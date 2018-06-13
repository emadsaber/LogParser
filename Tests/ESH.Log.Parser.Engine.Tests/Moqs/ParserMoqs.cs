using ESH.Log.Parser.Engine.Services.Parser.Support;
using ESH.Log.Parser.Engine.Services.Reader.Support;
using ESH.Log.Parser.Engine.Services.Support.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Tests.Moqs
{
    public static class ParserMoqs
    {
        public static ParserObject PO_SingleLineMessages => new ParserObject()
        {
            Format = null,
            PlainLines = new List<PlainLine>() {
                new PlainLine("" ) ,
                new PlainLine("") ,
                new PlainLine("")
            }
        };

    }
}
