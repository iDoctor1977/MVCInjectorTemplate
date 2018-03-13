using System.Collections.Generic;
using Injector.Common.DTOEntity;
using Injector.Common.IVModel;

namespace Injector.Frontend.Models
{
    public class VMListA : IVMListA
    {
        public IEnumerable<EntityA> ListDTOModelA { get; set; }
    }
}