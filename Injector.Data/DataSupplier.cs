using Injector.Common.IBind;
using Injector.Common.IRepository;
using Injector.Common.IStore;
using Injector.Common.ISupplier;
using Injector.Data.ADOModel;
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

        private DataSupplier(IDataBind dataBind) : base(dataBind) { }

        private DataSupplier(IDataStore dataStore, IDataBind dataBind) : base(dataStore, dataBind) { }

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

        public static IDataSupplier Instance(IDataBind dataBind)
        {
            if (DataSupplierInstance == null)
            {
                DataSupplierInstance = new DataSupplier(dataBind);
            }

            return DataSupplierInstance;
        }

        public static IDataSupplier Instance(IDataStore dataStore, IDataBind dataBind)
        {
            if (DataSupplierInstance == null)
            {
                DataSupplierInstance = new DataSupplier(dataStore, dataBind);
            }

            return DataSupplierInstance;
        }

        #endregion

        #region REPOSITORIES

        public IRepositoryA GetRepositoryA => _repositoryA ?? (_repositoryA = RepositoryA.Instance(ABaseStore)); // new RepositoryA()

        public IRepositoryB GetRepositoryB => _repositoryB ?? (_repositoryB = RepositoryB.Instance(ABaseStore)); // new RepositoryB()

        #endregion

        public void Commit()
        {
            ProjectDbContext dbContext = ABaseStore.StoreProjectDbContext as ProjectDbContext;
            dbContext.SaveChanges();
        }
    }
}