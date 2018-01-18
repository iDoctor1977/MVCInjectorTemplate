using Injector.Common.IRepository;
using Injector.Common.IStore;

namespace Injector.Common.ISupplier
{
    public interface IDataSupplier
    {
        IDataStore SupplierDataStore { get; set; }

        IRepositoryA GetRepositoryA { get; }
        IRepositoryB GetRepositoryB { get; }
    }
}