using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH.Log.Parser.Engine.Contracts
{
    public interface IService
    {
        IValidationTarget Target { get; set; }
    }
}
