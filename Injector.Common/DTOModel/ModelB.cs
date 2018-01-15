using System.ComponentModel.DataAnnotations;
using Injector.Common.IModel;

namespace Injector.Common.DTOModel
{
    public class ModelB : IModelB
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Username obbligatorio.")]
        [StringLength(15, ErrorMessage = "La lunghezza di {0} deve essere di almeno {2} caratteri.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email obbligatoria.")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Username")]
        [DataType(DataType.Date)]
        public string Birth { get; set; }
    }
}
