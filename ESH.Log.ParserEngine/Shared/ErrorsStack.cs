using ESH.Log.Parser.Engine.Validations.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Shared
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

        public static IEnumerable<ValidationError> GetAllErrors(bool RemoveAfterRead)
        {
            if (RemoveAfterRead)
            {
                while (_stack != null && _stack.Count != 0)
                {
                    yield return _stack.Pop();
                }
            }
            foreach (var item in _stack)
            {
                yield return item;
            }
        }

        public static IEnumerable<ValidationError> GetNewErrors(bool RemoveAfterRead)
        {
            if (RemoveAfterRead)
            {
                while (_stack != null && _stack.Count != 0 && _stack.Peek().IsNew == true)
                {
                    yield return _stack.Pop();
                }
            }
            var newErrors = _stack.Where(x => x.IsNew == true);
            foreach (var item in newErrors)
            {
                yield return item;
            }
        }

        public static ValidationError GetLastError()
        {
            if (_stack == null || _stack.Count == 0) return null;
            return _stack.Pop();
        }
    }
}
