using Injector.Common.ISupplier;

namespace Injector.Common.IStore
{
    public interface ICoreStore
    {
        IDataSupplier StoreDataSupplier { get; set; }
        ISharingSupplier StoreSharingSupplier { get; set; }
    }
}