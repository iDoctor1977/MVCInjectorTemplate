using Injector.Common.IBond;
using Injector.Common.IStore;

namespace Injector.Common.IABase
{
    public interface IABaseFeature
    {
        ICoreBond ABaseBond { get; set; }
        ICoreStore ABaseStore { get; set; }
    }
}