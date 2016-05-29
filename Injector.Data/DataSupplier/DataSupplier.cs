using Injector.Common.IRepository;
using Injector.Common.ISupplier;
using Injector.Data.DataLayer;

namespace Injector.Data.DataSupplier
{
    public class DataSupplier : IDataSupplier
    {
        private IRepositoryA RepositoryA;
        private IRepositoryB RepositoryB;

        public IRepositoryA GenerateRepositoryA()
        {
            return RepositoryA ?? (RepositoryA = new RepositoryA());
        }

        public IRepositoryB GenerateRepositoryB()
        {
            return RepositoryB ?? (RepositoryB = new RepositoryB());
        }
    }
}