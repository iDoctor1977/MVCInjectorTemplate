using Injector.Common.IRepository;
using Injector.Common.IStore;
using Injector.Common.ISupplier;
using Injector.Data.Layer;

namespace Injector.Data
{
    public class DataSupplier : IDataSupplier
    {
        private IDataStore _dataStore;

        private IRepositoryA RepositoryA;
        private IRepositoryB RepositoryB;

        public IDataStore DSupplierDataStore
        {
            get { return _dataStore ?? (_dataStore = DataStore.Instance()); }
            set { _dataStore = value; }
        }

        #region CONSTRUCTOR

        private DataSupplier()
        {
            if (DataSupplierInstance == null)
            {
                DataSupplierInstance = this;
            }
        }

        private DataSupplier(IDataStore dataStore)
        {
            DSupplierDataStore = dataStore;

            if (DataSupplierInstance == null)
            {
                DataSupplierInstance = this;
            }
        }

        #endregion

        #region SINGLETON

        private static IDataSupplier DataSupplierInstance { get; set; }

        public static IDataSupplier Instance()
        {
            return DataSupplierInstance = new DataSupplier();
        }

        public static IDataSupplier Instance(IDataStore dataStore)
        {
            return DataSupplierInstance = new DataSupplier(dataStore);
        }

        #endregion

        #region REPOSITOIES

        public IRepositoryA GetRepositoryA()
        {
            return RepositoryA ?? (RepositoryA = new RepositoryA());
        }

        public IRepositoryB GetRepositoryB()
        {
            return RepositoryB ?? (RepositoryB = new RepositoryB());
        }

        #endregion
    }
}