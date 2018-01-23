using System.Collections.Generic;
using Injector.Common.DTOModel;
using Injector.Common.IVModel;

namespace Injector.Frontend.Models
{
    public class VMListB : IVMListB
    {
        public IEnumerable<ModelB> ListDTOModelB { get; set; }
    }
}