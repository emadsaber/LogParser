using ESH.Log.ParserEngine.Validations.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.ParserEngine.Contracts
{
    public interface IValidator
    {
        string ModuleName { get; }
        bool Validate(IValidationTarget target, out List<ValidationError> errors);
    }
}
