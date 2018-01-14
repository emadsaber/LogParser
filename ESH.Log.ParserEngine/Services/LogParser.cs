using ESH.Log.Parser.Engine.Services.Parser.Support;
using ESH.Log.Parser.Engine.Services.Support.Parser;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Services
{
    public class LogParser
    {
        #region properties
        public ParserObject Target { get; set; }
        
        #endregion

        #region constructors
        public LogParser() { }
        public LogParser(ParserObject target)
        {
            this.Target = target;
        }
        #endregion

        #region logic
        public List<Message> Parse()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
