using Injector.Common.IStore;

namespace Injector.Common.IABase
{
    public interface IABaseController
    {
        IWebStore ABaseStore { get; set; }
    }
}