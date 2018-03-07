using System.Collections.Generic;
using Injector.Common.DTOModel;

namespace Injector.Common.IVModel
{
    public interface IVMListA
    {
        IEnumerable<EntityA> ListDTOModelA { get; set; }
    }
}