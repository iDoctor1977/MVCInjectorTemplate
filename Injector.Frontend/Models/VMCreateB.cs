using System.ComponentModel.DataAnnotations;
using Injector.Common.DTOEntity;
using Injector.Common.IVModel;

namespace Injector.Frontend.Models
{
    public class VMCreateB : IVMCreateB
    {
        [Display(Name = "Data di nascita")]
        [DataType(DataType.DateTime)]
        public string Birth { get; set; }

        public EntityB DTOModelB { get; set; }
    }
}