using Injector.Common.IRepository;
using Injector.Common.IStore;

namespace Injector.Common.ISupplier
{
    public interface IDataSupplier
    {
        IDataStore DSupplierDataStore { get; set; }

        IRepositoryA GetRepositoryA();
        IRepositoryB GetRepositoryB();
    }
}