using ESH.Log.Parser.Engine.Contracts;
using ESH.Log.Parser.Engine.Services.Reader.Support;
using ESH.Log.Parser.Engine.Shared;
using ESH.Log.Parser.Engine.Validations;
using ESH.Log.Parser.Engine.Validations.Support;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Services
{
    public class LogReader : IService
    {
        #region properties
        public IValidationTarget Target { get; set; }

        #endregion

        #region constructors
        public LogReader() { }
        public LogReader(ReaderObject target)
        {
            this.Target = target;   
        }

        #endregion

        #region logic
        public List<PlainLine> Read()
        {
            List<ValidationError> errors = null;
            //validate target
            if (!new ReaderValidator().Validate(Target, out errors))
            {
                if (errors != null && errors.Count > 0) ErrorsStack.AddErrors(errors);
                return null;
            }
            var target = this.Target as ReaderObject;
            //process target
            FileStream fs = new FileStream(target.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            List<PlainLine> lines = new List<PlainLine>();
            int lineIndex = 0;
            while (!sr.EndOfStream)
            {
                if (target.PageSize.HasValue && target.PageIndex.HasValue)
                {
                    if (lineIndex >= (target.PageSize.Value * target.PageIndex.Value) &&
                        lineIndex < target.PageSize.Value + (target.PageSize.Value * target.PageIndex.Value))
                    {
                        lines.Add(new PlainLine(sr.ReadLine()));
                    }
                    else
                    {
                        var dump = sr.ReadLine(); // to skip this line
                    }
                    if (lines.Count == target.PageSize.Value) break;
                }
                else
                {
                    lines.Add(new PlainLine(sr.ReadLine()));
                }
                lineIndex++;
            }
            return lines;
        } 
        #endregion
    }
}
