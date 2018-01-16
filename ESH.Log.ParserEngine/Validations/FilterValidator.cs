using ESH.Log.Parser.Engine.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESH.Log.Parser.Engine.Validations.Support;
using ESH.Log.Parser.Engine.Services.Support.Filter;
using ESH.Log.Parser.Resources;

namespace ESH.Log.Parser.Engine.Validations
{
    public class FilterValidator : IValidator
    {
        public string ModuleName => "Filter Module";

        public bool Validate(IValidationTarget target, out List<ValidationError> errors)
        {
            errors = new List<ValidationError>();
            if (target == null)
            {
                errors.Add(new ValidationError() { ErrorMessage = ValidationResources.ERR_Invalid_Target, SourceModule = this.ModuleName, TimeStamp = DateTime.Now });
                return false;
            }

            var filterTarget = target as FilterObject;
            if (filterTarget == null)
            {
                errors.Add(new ValidationError() { ErrorMessage = ValidationResources.ERR_Invalid_Target, SourceModule = this.ModuleName, TimeStamp = DateTime.Now });
                return false;
            }
            if (filterTarget.Messages == null)
            {
                errors.Add(new ValidationError() { ErrorMessage = ValidationResources.ERR_Filter_Invalid_Source_Messages, SourceModule = this.ModuleName, TimeStamp = DateTime.Now });
                return false;
            }
            if (filterTarget.SelectedRange != null)
            {
                if (filterTarget.SelectedRange.From == default(DateTime) || filterTarget.SelectedRange.To == default(DateTime))
                {
                    errors.Add(new ValidationError() { ErrorMessage = ValidationResources.ERR_Filter_Invalid_Date_Range, SourceModule = this.ModuleName, TimeStamp = DateTime.Now });
                    return false;
                }
                if (filterTarget.SelectedRange.From == filterTarget.SelectedRange.To)
                {
                    errors.Add(new ValidationError() { ErrorMessage = ValidationResources.ERR_Filter_Invalid_Date_Range, SourceModule = this.ModuleName, TimeStamp = DateTime.Now });
                    return false;
                }
            }
            return true;
        }
    }
}
