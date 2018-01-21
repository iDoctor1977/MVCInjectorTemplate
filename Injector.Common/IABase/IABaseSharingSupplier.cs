using Injector.Common.IStore;

namespace Injector.Common.IABase
{
    internal interface IABaseSharingSupplier
    {
        ISharingStore SupplierSharingStore { get; set; }
    }
}