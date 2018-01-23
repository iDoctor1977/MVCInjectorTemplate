using Injector.Common.ILogic;

namespace Injector.Common.ISupplier
{
    public interface ICoreSupplier
    {
        ILogicA GetLogicA { get; }
        ILogicB GetLogicB { get; }
    }
}