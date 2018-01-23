using Injector.Common.IRepository;

namespace Injector.Common.ISupplier
{
    public interface IDataSupplier
    {
        IRepositoryA GetRepositoryA { get; }
        IRepositoryB GetRepositoryB { get; }
    }
}