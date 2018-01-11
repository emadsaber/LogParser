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
                error.IsNew = true;
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
            foreach (var item in _stack)
            {
                item.IsNew = false;
            }
            return _stack.Select(x => x).ToList();
        }

        public static List<ValidationError> GetNewErrors()
        {
            try
            {
                return _stack.Where(x => x.IsNew == true).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static ValidationError GetLastError()
        {
            if (_stack == null || _stack.Count == 0) return null;
            return _stack.Pop();
        }
    }
}
