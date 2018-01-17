using ESH.Log.Parser.Engine.Contracts;
using ESH.Log.Parser.Engine.Services.Reader.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESH.Log.Parser.Engine.Validations.Support;
using ESH.Log.Parser.Engine.Services.Support.Parser;
using ESH.Log.Parser.Resources;

namespace ESH.Log.Parser.Engine.Services.Parser.Support
{
    public class ParserObject:IValidationTarget
    {
        #region properties
        public List<PlainLine> PlainLines { get; set; }
        public MessageFormat Format { get; set; }
        
        #endregion
    }
}
