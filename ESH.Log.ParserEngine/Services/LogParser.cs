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
            var portions = Regex.Matches(format, @"\[[A-Z][a-z]*\]").Cast<string>().ToArray();
            var message = new Message();
            var messages = new List<Message>();
            bool isMessageSpanning = false;
            //parse messages
            for (int lineIndex = 0; lineIndex < Target.PlainLines.Count; lineIndex++)
            {
                if (!isMessageSpanning)
                {
                    message = new Message();
                    for (int portionIndex = 0; portionIndex < portions.Length; portionIndex++)
                    {
                        isMessageSpanning = IsCurrentMessageSpanning(lineIndex, out string[] spanningLines);
                        if (portions[portionIndex] == AppResources.Parser_Format_Stamp) { message.TimeStamp = GetTimeStamp(Target.PlainLines[lineIndex], portionIndex); }
                        if (portions[portionIndex] == AppResources.Parser_Format_Type) { message.Type = GetMessageType(Target.PlainLines[lineIndex], portionIndex); }
                        if (portions[portionIndex] == AppResources.Parser_Format_Message) { message.MessageBuilder = GetMessageBuilder(Target.PlainLines[lineIndex], portionIndex); }
                    }
                    messages.Add(message);
                }

                //TODO: find a way to detect spanning messages
                //TODO: parse spanned messages by adding it to MessageBuilder

            }
                return new List<Message>();
        }

        private bool? IsCurrentMessageSpanning(int lineIndex, out string[] spanningLines)
        {
            spanningLines = null;
            if (lineIndex >= Target.PlainLines.Count - 1) return null;
            var nextLine = Target.PlainLines[lineIndex + 1].Line;
            var firstOpeningIndex = nextLine.IndexOf('[');
            if (firstOpeningIndex == -1) return null;

            var firstClosingIndex = nextLine.IndexOf(']');
            if (firstClosingIndex == -1) return null;
            if (firstOpeningIndex > firstClosingIndex) return null;

            var date = nextLine.Substring(firstOpeningIndex + 1, firstClosingIndex);
            DateTime datetime = DateTime.MinValue;
            if (!DateTime.TryParseExact(date, Target.Format.TimeStampFormat, null, System.Globalization.DateTimeStyles.None, out datetime))
            {

                return false;
            }
            return true;
        }
         
        private StringBuilder GetMessageBuilder(PlainLine line, int portionIndex)
        {
            throw new NotImplementedException();
        }

        private DateTime? GetTimeStamp(PlainLine line, int portionIndex)
        {
            throw new NotImplementedException();
        }

        private LogType GetMessageType(PlainLine line, int portionIndex)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
