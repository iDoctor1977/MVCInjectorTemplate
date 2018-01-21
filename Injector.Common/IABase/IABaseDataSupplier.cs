using Injector.Common.IStore;

namespace Injector.Common.IABase
{
    public interface IABaseDataSupplier
    {
        IDataStore SupplierDataStore { get; set; }
    }
}