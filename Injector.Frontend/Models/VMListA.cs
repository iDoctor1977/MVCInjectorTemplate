using System.Collections.Generic;
using Injector.Common.DTOModel;
using Injector.Common.IVModel;

namespace Injector.Frontend.Models
{
    public class VMListA : IVMListA
    {
        public IEnumerable<EntityA> ListDTOModelA { get; set; }
    }
}