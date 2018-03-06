using System;
using System.ComponentModel.DataAnnotations;
using Injector.Common.IEntity;

namespace Injector.Common.DTOModel
{
    public class ModelA : IEntityA
    {
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Cognome")]
        [DataType(DataType.Text)]
        public string Surname { get; set; }

        [ScaffoldColumn(false)]
        public bool IsDeleted { get; set; }

        [ScaffoldColumn(false)]
        public string DeleteBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? DeleteDate { get; set; }
    }
}
