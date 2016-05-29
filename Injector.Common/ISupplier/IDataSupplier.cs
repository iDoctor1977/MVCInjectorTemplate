using Injector.Common.IRepository;

namespace Injector.Common.ISupplier
{
    public interface IDataSupplier
    {
        IRepositoryA GenerateRepositoryA();
        IRepositoryB GenerateRepositoryB();
    }
}