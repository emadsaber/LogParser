using ESH.Log.ParserEngine.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESH.Log.ParserEngine.Validations.Support;
using ESH.Log.Parser.Resources;
using System.IO;
using ESH.Log.ParserEngine.Services.Support;

namespace ESH.Log.ParserEngine.Validations
{
    public class ReaderValidator : IValidator
    {
        public string ModuleName { get; } = "ReaderValidator";

        public bool Validate(IValidationTarget target, out List<ValidationError> errors)
        {
            errors = new List<ValidationError>();
            if (target == null)
            {
                errors.Add(new ValidationError() { ErrorMessage= ValidationResources.ERR_Invalid_Target, SourceModule = this.ModuleName, TimeStamp = DateTime.Now });
                return false;
            }

            var readerTarget = target as ReaderObject;
            if(readerTarget == null)
            {
                errors.Add(new ValidationError() { ErrorMessage = ValidationResources.ERR_Invalid_Target, SourceModule = this.ModuleName, TimeStamp = DateTime.Now });
                return false;
            }
            if (!File.Exists(readerTarget.FileName))
            {
                errors.Add(new ValidationError() { ErrorMessage = ValidationResources.ERR_Log_File_Not_Exist, SourceModule = this.ModuleName, TimeStamp = DateTime.Now });
                return false;
            }
            return true;
        }
    }
}
