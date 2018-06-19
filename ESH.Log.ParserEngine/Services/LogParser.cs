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
            var portions = Regex.Matches(format, @"\[[A-Z][a-z]*\]").Cast<Match>().Select(x => x.Value).ToArray();
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
                        List<PlainLine> spanningLines = null;
                        isMessageSpanning = IsCurrentMessageSpanning(lineIndex, out spanningLines) ?? false;
                        if (portions[portionIndex] == AppResources.Parser_Format_Stamp) { message.TimeStamp = GetTimeStamp(Target.PlainLines[lineIndex]); }
                        if (portions[portionIndex] == AppResources.Parser_Format_Type) { message.Type = GetMessageType(Target.PlainLines[lineIndex]) ?? LogType.Undefined; }
                        if (portions[portionIndex] == AppResources.Parser_Format_Message) { message.MessageBuilder = GetMessageBuilder(Target.PlainLines[lineIndex], spanningLines); }
                    }
                    messages.Add(message);
                }

                //TODO: find a way to detect spanning messages
                //TODO: parse spanned messages by adding it to MessageBuilder

            }
            return messages;
        }

        private bool? IsCurrentMessageSpanning(int lineIndex, out List<PlainLine> spanningLines)
        {
            spanningLines = new List<PlainLine>();
            if (lineIndex >= Target.PlainLines.Count - 1) return null;
            var nextLine = Target.PlainLines[lineIndex + 1].Line;
            if(IsLineStartsWithDate(nextLine)) return false;
            
            //get spanning lines
            var index = lineIndex + 2 < Target.PlainLines.Count ? lineIndex + 2 : -1;
            var stop = false;

            while (!stop)
            {
                if (index == -1 || index + 1 >= Target.PlainLines.Count) return null;
                var line = Target.PlainLines[index];

                var isNextLineANewMesssage = IsLineStartsWithDate(line.Line);
                if (isNextLineANewMesssage) { index++; stop = false; }
                else { stop = true; }
                spanningLines.Add(line);
            }
            return true;
        }
        private bool IsLineStartsWithDate(string line)
        {
            var dateStamp = new Regex(AppResources.DefaultTimeStampRegexFormat);
            return dateStamp.IsMatch(line);
        }
        private StringBuilder GetMessageBuilder(PlainLine line, List<PlainLine> spanningLines)
        {
            var sb = new StringBuilder();
            var msgType = GetMessageType(line);
            var isFirstLineInMessage = msgType != null;
            var isSingleLineMessage = spanningLines == null;

            if(!isFirstLineInMessage)
            {
                if (isSingleLineMessage) return sb.Append(line.Line);
            }
            else
            {
                if(isSingleLineMessage) return sb.Append(GetMessage(line, msgType.Value));
                
                foreach (var item in spanningLines)
                {
                    sb.Append(item.Line);
                }
                return sb;
            }

            return sb;
        }

        private string GetMessage(PlainLine line, LogType msgType)
        {
            string msgTypeString = $"[{msgType.ToString()}]";
            var firstMessagCharacterIndex = line.Line.IndexOf(msgTypeString);
            if (firstMessagCharacterIndex == -1) return null;
            return line.Line.Substring(firstMessagCharacterIndex);
        }
        public string GetSingleLineMessage(PlainLine line)
        {
            return GetMessageBuilder(line, null)?.ToString();
        }
        private DateTime? GetTimeStamp(PlainLine line)
        {
            var dateStamp = new Regex(AppResources.DefaultTimeStampRegexFormat);
            if (!dateStamp.IsMatch(line.Line)) return null;
            var match = dateStamp.Match(line.Line).Value;
            DateTime result;
            //TODO : change substring with more efficient technique
            if (!DateTime.TryParseExact(match.Substring(1, match.Length-2), AppResources.DefaultTimeStampFormat, null, System.Globalization.DateTimeStyles.AssumeLocal, out result)) return null;
            return result;
        }

        private LogType? GetMessageType(PlainLine line)
        {
            var match = new Regex(AppResources.DefaultMessageTypeRegexFormat);
            if (!match.IsMatch(line.Line)) return null;
            var messageType = match.Match(line.Line).Value;
            LogType result;
            if (!Enum.TryParse(messageType, out result)) return null;
            return result;
        }
        #endregion
    }
}
