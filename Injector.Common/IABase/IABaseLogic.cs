using Injector.Common.IBind;
using Injector.Common.IStore;

namespace Injector.Common.IABase
{
    public interface IABaseLogic
    {
        ICoreBind ABaseBind { get; set; }
        ICoreStore ABaseStore { get; set; }
    }
}