using ESH.Log.ParserEngine.Validations.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.ParserEngine.Shared
{
    public static class ErrorsStack
    {
        static ErrorsStack()
        {
            _stack = new Stack<ValidationError>();
        }
        private static Stack<ValidationError> _stack { get; }

        public static bool AddError(ValidationError error)
        {
            try
            {
                _stack.Push(error);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool AddErrors(List<ValidationError> errors)
        {
            bool res = true;
            foreach (var error in errors)
            {
                res &= AddError(error);
            }
            return res;
        }

        public static List<ValidationError> GetAllErrors()
        {
            return _stack.Select(x => x).ToList();
        }
    }
}
