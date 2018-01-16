using ESH.Log.Parser.Engine.Contracts;
using ESH.Log.Parser.Engine.Services.Support.Filter;
using ESH.Log.Parser.Engine.Services.Support.Parser;
using ESH.Log.Parser.Engine.Shared;
using ESH.Log.Parser.Engine.Validations;
using ESH.Log.Parser.Engine.Validations.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Services
{
    public class LogFilter:IService
    {
        #region properties

        public IValidationTarget Target { get; set; }

        #endregion

        #region constructors
        public LogFilter() { }
        public LogFilter(FilterObject target)
        {
            this.Target = target;
        }

        #endregion

        #region logic
        public List<Message> Filter()
        {
            List<ValidationError> errors = null;
            //validate target
            if (!new FilterValidator().Validate(Target, out errors))
            {
                if (errors != null && errors.Count > 0) ErrorsStack.AddErrors(errors);
                return null;
            }

            #region prepare

            var target = this.Target as FilterObject;

            var messagesFiltered = target.Messages; 

            #endregion

            #region filtration

            if (target.SelectedTypes != null && target.SelectedTypes.Count > 0)
            {
                messagesFiltered = messagesFiltered.Where(x => target.SelectedTypes.Contains(x.Type)).ToList();
            }
            if (target.SelectedTimeStamps != null && target.SelectedTimeStamps.Count > 0)
            {
                messagesFiltered = messagesFiltered.Where(x => x.TimeStamp.HasValue ? target.SelectedTimeStamps.Contains(x.TimeStamp.Value) : false).ToList();
            }
            if (target.SelectedRange != null)
            {
                messagesFiltered = messagesFiltered.Where(x => x.TimeStamp.HasValue ?
                                                                x.TimeStamp.Value >= target.SelectedRange.From &&
                                                                x.TimeStamp.Value < target.SelectedRange.To : false).ToList();
            }
            if (target.MessageCriteria != null)
            {
                messagesFiltered = messagesFiltered.Where(x => x.TextMessage.Contains(target.MessageCriteria)).ToList();
            }

            #endregion

            return messagesFiltered;
        }
        #endregion
    }
}
