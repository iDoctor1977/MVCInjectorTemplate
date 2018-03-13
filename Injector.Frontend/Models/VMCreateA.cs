using System.ComponentModel.DataAnnotations;
using Injector.Common.DTOEntity;
using Injector.Common.IVModel;

namespace Injector.Frontend.Models
{
    public class VMCreateA : IVMCreateA
    {
        [Display(Name = "Numero di telefono")]
        [DataType(DataType.Text)]
        public string TelNumber { get; set; }

        public EntityA DTOModelA { get; set; }
    }
}