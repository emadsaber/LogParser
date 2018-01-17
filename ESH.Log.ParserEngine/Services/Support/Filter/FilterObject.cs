using ESH.Log.Parser.Engine.Contracts;
using ESH.Log.Parser.Engine.Services.Support.Parser;
using ESH.Log.Parser.Engine.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Services.Support.Filter
{
    public class FilterObject:IValidationTarget
    {
        #region properties

        public List<Message> Messages { get; set; }
        public List<DateTime> SelectedTimeStamps { get; set; }
        public List<LogType> SelectedTypes { get; set; }
        public DateRange SelectedRange { get; set; }
        public bool AllowDuplicates { get; set; } = true;
        public string MessageCriteria { get; set; }

        #endregion
    }
}
