using System.ComponentModel.DataAnnotations;
using Injector.Common.IModel;

namespace Injector.Frontend.Models.ViewModelsB
{
    public class AViewModelB : IModelB
    {
        public int Id { get; set; }

        [Display(Name = "Username")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.Text)]
        public string Email { get; set; }
    }
}