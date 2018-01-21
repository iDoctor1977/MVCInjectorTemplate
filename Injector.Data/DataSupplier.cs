using Injector.Common.IRepository;
using Injector.Common.IStore;
using Injector.Common.ISupplier;
using Injector.Data.Layer;

namespace Injector.Data
{
    public class DataSupplier : ABaseDataSupplier, IDataSupplier
    {
        private IRepositoryA _repositoryA;
        private IRepositoryB _repositoryB;

        #region CONSTRUCTOR

        private DataSupplier() { }

        private DataSupplier(IDataStore dataStore) : base(dataStore) { }

        #endregion

        #region SINGLETON

        private static IDataSupplier DataSupplierInstance { get; set; }

        public static IDataSupplier Instance()
        {
            if (DataSupplierInstance == null)
            {
                DataSupplierInstance = new DataSupplier();
            }

            return DataSupplierInstance;
        }

        public static IDataSupplier Instance(IDataStore dataStore)
        {
            if (DataSupplierInstance == null)
            {
                DataSupplierInstance = new DataSupplier(dataStore);
            }

            return DataSupplierInstance;
        }

        #endregion

        #region REPOSITORIES

        public IRepositoryA GetRepositoryA => _repositoryA ?? (_repositoryA = RepositoryA.Instance(SupplierDataStore)); // new RepositoryA()

        public IRepositoryB GetRepositoryB => _repositoryB ?? (_repositoryB = RepositoryB.Instance(SupplierDataStore)); // new RepositoryB()

        #endregion
    }
}