using Injector.Common.IBond;
using Injector.Common.IStore;

namespace Injector.Common.IABase
{
    public interface IABaseLogic
    {
        ICoreBond ABaseBond { get; set; }
        ICoreStore ABaseStore { get; set; }
    }
}