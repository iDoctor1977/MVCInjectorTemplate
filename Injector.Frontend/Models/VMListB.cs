using System.Collections.Generic;
using Injector.Common.DTOEntity;
using Injector.Common.IVModel;

namespace Injector.Frontend.Models
{
    public class VMListB : IVMListB
    {
        public IEnumerable<EntityB> ListDTOModelB { get; set; }
    }
}