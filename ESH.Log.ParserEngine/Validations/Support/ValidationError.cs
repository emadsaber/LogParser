using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.ParserEngine.Validations.Support
{
    public class ValidationError
    {
        public string ErrorMessage { get; set; }
        public string SourceModule { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsNew { get; set; }
    }
}
