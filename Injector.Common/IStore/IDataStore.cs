using Injector.Common.IBind;
using Injector.Common.ISupplier;
using Injector.Common.IDbContext;

namespace Injector.Common.IStore
{
    public interface IDataStore
    {
        IDataBind StoreDataBind { get; set; }
        string StoreConnectionStringName { get; set; }
        IProjectDbContext StoreProjectDbContext { get; set; }
        ISharingSupplier StoreSharingSupplier { get; set; }
    }
}