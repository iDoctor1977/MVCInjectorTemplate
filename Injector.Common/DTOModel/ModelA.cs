using System;
using System.ComponentModel.DataAnnotations;
using Injector.Common.IModel;

namespace Injector.Common.DTOModel
{
    public class ModelA : IModelA
    {
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Cognome")]
        [DataType(DataType.Text)]
        public string Surname { get; set; }
    }
}
