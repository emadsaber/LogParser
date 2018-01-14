using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Services.Reader.Support
{
    public class PlainLine
    {
        public string Line { get; set; }
        public PlainLine(string line)
        {
            this.Line = line;
        }

        public override string ToString()
        {
            return this.Line;
        }
    }
}
