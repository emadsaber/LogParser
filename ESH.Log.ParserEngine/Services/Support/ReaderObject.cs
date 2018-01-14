using ESH.Log.ParserEngine.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.ParserEngine.Services.Support
{
    public class ReaderObject:IValidationTarget
    {
        public string FileName { get; set; }
        public int? PageSize { get; set; } //if you don't set a value, reader will read all file at a time
        public int? PageIndex { get; set; } //if you don't set a value, reader will read all file at a time
    }
}
