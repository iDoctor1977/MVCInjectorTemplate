using System.Collections.Generic;
using Injector.Common.DTOEntity;

namespace Injector.Common.IVModel
{
    public interface IVMListA
    {
        IEnumerable<EntityA> ListDTOModelA { get; set; }
    }
}