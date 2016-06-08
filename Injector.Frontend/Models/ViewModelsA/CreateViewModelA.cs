using System.Collections.Generic;
using Injector.Frontend.Models.ViewModelsB;

namespace Injector.Frontend.Models.ViewModelsA
{
    public class CreateViewModelA : AViewModelA
    {
        public CreateViewModelA()
        {
            ColCreateViewModelB = new List<CreateViewModelB>();
        }

        public string TelNumber { get; set; }
        public ICollection<CreateViewModelB> ColCreateViewModelB { get; set; }
    }
}