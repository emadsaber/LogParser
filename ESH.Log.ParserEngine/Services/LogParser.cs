using ESH.Log.Parser.Engine.Services.Parser.Support;
using ESH.Log.Parser.Engine.Services.Support.Parser;
using ESH.Log.Parser.Engine.Shared;
using ESH.Log.Parser.Engine.Validations;
using ESH.Log.Parser.Engine.Validations.Support;
using ESH.Log.Parser.Resources;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ESH.Log.Parser.Engine.Services.Reader.Support;

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
            List<ValidationError> errors = null;
            //validate target
            if (!new ParserValidator().Validate(Target, out errors))
            {
                if (errors != null && errors.Count > 0) ErrorsStack.AddErrors(errors);
                return null;
            }
            var format = Target.Format.FullFormat;
            var portions = Regex.Matches(format, @"\[[A-Z][a-z]*\]");
            var message = new Message();
            var messages = new List<Message>();
            bool isMessageSpanning = false;
            //parse messages
            foreach (var line in Target.PlainLines)
            {
                if (!isMessageSpanning)
                {
                    message = new Message();
                    if (format.Contains(AppResources.Parser_Format_Type)) { message.Type = GetMessageType(line); }
                    if (format.Contains(AppResources.Parser_Format_Stamp)) { message.TimeStamp = GetTimeStamp(line); }
                    if (format.Contains(AppResources.Parser_Format_Message)) { message.MessageBuilder = GetMessageBuilder(line, out isMessageSpanning); }
                    messages.Add(message);
                }

                //TODO: find a way to detect spanning messages
                //TODO: parse spanned messages by adding it to MessageBuilder

            }
                return new List<Message>();
        }

        private StringBuilder GetMessageBuilder(PlainLine line, out bool isMessageSpanning)
        {
            throw new NotImplementedException();
        }

        private DateTime? GetTimeStamp(PlainLine line)
        {
            throw new NotImplementedException();
        }

        private LogType GetMessageType(PlainLine line)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
