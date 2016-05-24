using Injector.Common.IModel;

namespace Injector.Frontend.Models.ViewModelsA
{
    public class ControllerViewModelA : AViewModelA
    {
        public IModelB ModelB { get; set; }
        public string TelNumber { get; set; }
    }
}