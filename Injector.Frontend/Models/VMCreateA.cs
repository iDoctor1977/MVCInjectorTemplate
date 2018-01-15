using System.ComponentModel.DataAnnotations;
using Injector.Common.DTOModel;
using Injector.Common.IVModel;

namespace Injector.Frontend.Models
{
    public class VMCreateA : IVMCreateA
    {
        [Display(Name = "Numero di telefono")]
        [DataType(DataType.Text)]
        public string TelNumber { get; set; }

        public ModelA DTOModelA { get; set; }
    }
}