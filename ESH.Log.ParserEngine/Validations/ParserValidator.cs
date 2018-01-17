using ESH.Log.Parser.Engine.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESH.Log.Parser.Engine.Validations.Support;
using ESH.Log.Parser.Resources;
using ESH.Log.Parser.Engine.Services.Parser.Support;

namespace ESH.Log.Parser.Engine.Validations
{
    public class ParserValidator : IValidator
    {
        public string ModuleName => "Parser Module";

        public bool Validate(IValidationTarget target, out List<ValidationError> errors)
        {
            errors = new List<ValidationError>();
            if (target == null)
            {
                errors.Add(new ValidationError() { ErrorMessage = ValidationResources.ERR_Invalid_Target, SourceModule = this.ModuleName, TimeStamp = DateTime.Now });
                return false;
            }

            var parserTarget = target as ParserObject;
            if (parserTarget == null)
            {
                errors.Add(new ValidationError() { ErrorMessage = ValidationResources.ERR_Invalid_Target, SourceModule = this.ModuleName, TimeStamp = DateTime.Now });
                return false;
            }
            if(parserTarget.Format == null)
            {
                errors.Add(new ValidationError() { ErrorMessage = ValidationResources.ERR_Parser_Invalid_Format, SourceModule = this.ModuleName, TimeStamp = DateTime.Now });
                return false;
            }
            if (string.IsNullOrEmpty(parserTarget.Format.FullFormat) || 
                (parserTarget.Format.IsIncludingTimeStamp && string.IsNullOrEmpty(parserTarget.Format.TimeStampFormat)))
            {
                errors.Add(new ValidationError() { ErrorMessage = ValidationResources.ERR_Parser_Invalid_Format, SourceModule = this.ModuleName, TimeStamp = DateTime.Now });
                return false;
            }
            if (parserTarget.PlainLines == null)
            {
                errors.Add(new ValidationError() { ErrorMessage = ValidationResources.ERR_Invalid_Target, SourceModule = this.ModuleName, TimeStamp = DateTime.Now });
                return false;
            }
            return true;
        }
    }
}
