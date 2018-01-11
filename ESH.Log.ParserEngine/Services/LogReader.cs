using ESH.Log.ParserEngine.Services.Support;
using ESH.Log.ParserEngine.Shared;
using ESH.Log.ParserEngine.Validations;
using ESH.Log.ParserEngine.Validations.Support;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.ParserEngine.Services
{
    public class LogReader
    {
        #region properties
        public ReaderObject Target { get; set; }

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
            //process target
            FileStream fs = new FileStream(Target.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            List<PlainLine> lines = new List<PlainLine>();
            while (!sr.EndOfStream)
            {
                lines.Add(new PlainLine(sr.ReadLine()));
            }
            return lines;
        } 
        #endregion
    }
}
