using System.ComponentModel.DataAnnotations;

namespace Injector.Frontend.Models.ViewModelsB
{
    public class CreateViewModelB : AViewModelB
    {
        [Display(Name = "Username")]
        [DataType(DataType.Date)]
        public string Birth { get; set; }
    }
}