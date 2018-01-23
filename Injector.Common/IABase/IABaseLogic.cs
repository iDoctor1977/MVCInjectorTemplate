using Injector.Common.IStore;

namespace Injector.Common.IABase
{
    public interface IABaseLogic
    {
        ICoreStore ABaseStore { get; set; }
    }
}