using Injector.Common.IStore;

namespace Injector.Common.IABase
{
    public interface IABaseCoreSupplier
    {
        ICoreStore SupplierCoreStore { get; set; }
    }
}