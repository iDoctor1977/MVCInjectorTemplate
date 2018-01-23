using System.Collections.Generic;
using Injector.Common.DTOModel;

namespace Injector.Common.IVModel
{
    public interface IVMListB
    {
        IEnumerable<ModelA> ListDTOModelA { get; set; }
    }
}