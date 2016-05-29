using System.ComponentModel.DataAnnotations;
using Injector.Common.IModel;

namespace Injector.Frontend.Models.ViewModelsA
{
    public class AViewModelA : IModelA
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Cognome")]
        [DataType(DataType.Text)]
        public string Surname { get; set; }
    }
}