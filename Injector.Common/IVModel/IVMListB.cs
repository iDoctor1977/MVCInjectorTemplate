using System.Collections.Generic;
using Injector.Common.DTOEntity;

namespace Injector.Common.IVModel
{
    public interface IVMListB
    {
        IEnumerable<EntityB> ListDTOModelB { get; set; }
    }
}