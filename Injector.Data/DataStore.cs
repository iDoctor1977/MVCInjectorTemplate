using Injector.Common;
using Injector.Common.IBind;
using Injector.Common.IDbContext;
using Injector.Common.IEntity;
using Injector.Common.IStore;
using Injector.Common.ISupplier;
using Injector.Data.ADOModel;

namespace Injector.Data
{
    internal class DataStore : IDataStore
    {
        private IDataBind _dataBind;
        private string _connectionString;
        private IProjectDbContext _projectDbContext;
        private ISharingSupplier _sharingSupplier;

        #region CONSTRUCTOR

        private DataStore() { }

        private DataStore(IDataBind dataBind)
        {
            StoreDataBind = dataBind;
        }

        private DataStore(string connectionString)
        {
            StoreConnectionStringName = connectionString;
        }

        private DataStore(string connectionString, IDataBind dataBind)
        {
            StoreConnectionStringName = connectionString;
            StoreDataBind = dataBind;
        }

        private DataStore(IProjectDbContext dbContext)
        {
            StoreProjectDbContext = dbContext;
        }

        private DataStore(IProjectDbContext dbContext, string connectionString)
        {
            StoreProjectDbContext = dbContext;
            StoreConnectionStringName = connectionString;
        }

        private DataStore(IProjectDbContext dbContext, IDataBind dataBind)
        {
            StoreProjectDbContext = dbContext;
            StoreDataBind = dataBind;
        }

        private DataStore(IProjectDbContext dbContext, IDataBind dataBind, string connectionString)
        {
            StoreProjectDbContext = dbContext;
            StoreDataBind = dataBind;
            StoreConnectionStringName = connectionString;
        }

        private DataStore(ISharingSupplier commonSupplier)
        {
            StoreSharingSupplier = commonSupplier;
        }

        private DataStore(ISharingSupplier commonSupplier, IDataBind dataBind)
        {
            StoreSharingSupplier = commonSupplier;
            StoreDataBind = dataBind;
        }

        private DataStore(ISharingSupplier commonSupplier, IProjectDbContext dbContext)
        {
            StoreSharingSupplier = commonSupplier;
            StoreProjectDbContext = dbContext;
        }

        private DataStore(ISharingSupplier commonSupplier, string connectionString)
        {
            StoreSharingSupplier = commonSupplier;
            StoreConnectionStringName = connectionString;
        }

        private DataStore(ISharingSupplier commonSupplier, IProjectDbContext dbContext, IDataBind dataBind)
        {
            StoreSharingSupplier = commonSupplier;
            StoreProjectDbContext = dbContext;
            StoreDataBind = dataBind;
        }

        private DataStore(ISharingSupplier commonSupplier, IProjectDbContext dbContext, string connectionString)
        {
            StoreSharingSupplier = commonSupplier;
            StoreProjectDbContext = dbContext;
            StoreConnectionStringName = connectionString;
        }

        private DataStore(ISharingSupplier commonSupplier, IDataBind dataBind, string connectionString)
        {
            StoreSharingSupplier = commonSupplier;
            StoreDataBind = dataBind;
            StoreConnectionStringName = connectionString;
        }

        private DataStore(ISharingSupplier commonSupplier, IProjectDbContext dbContext, string connectionString, IDataBind dataBind)
        {
            StoreSharingSupplier = commonSupplier;
            StoreProjectDbContext = dbContext;
            StoreConnectionStringName = connectionString;
            StoreDataBind = dataBind;
        }

        #endregion

        #region SINGLETON

        private static IDataStore DataStoreInstance { get; set; }

        public static IDataStore Instance()
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore();
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(IDataBind dataBind)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(dataBind);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(string connectionString)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(connectionString);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(string connectionString, IDataBind dataBind)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(connectionString, dataBind);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(IProjectDbContext dbContext)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(dbContext);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(IProjectDbContext dbContext, IDataBind dataBind)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(dbContext, dataBind);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(IProjectDbContext dbContext, string connectionString)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(dbContext, connectionString);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(IProjectDbContext dbContext, IDataBind dataBind, string connectionString)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(dbContext, dataBind, connectionString);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(ISharingSupplier commonSupplier)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(commonSupplier);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(ISharingSupplier commonSupplier, IDataBind dataBind)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(commonSupplier, dataBind);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(ISharingSupplier commonSupplier, IProjectDbContext dbContext)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(commonSupplier, dbContext);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(ISharingSupplier commonSupplier, string connectionString)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(commonSupplier, connectionString);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(ISharingSupplier commonSupplier, IDataBind dataBind, string connectionString)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(commonSupplier, dataBind, connectionString);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(ISharingSupplier commonSupplier, IProjectDbContext dbContext, string connectionString)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(commonSupplier, dbContext, connectionString);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(ISharingSupplier commonSupplier, IProjectDbContext dbContext, IDataBind dataBind)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(commonSupplier, dbContext, dataBind);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(ISharingSupplier commonSupplier, IProjectDbContext dbContext, IDataBind dataBind, string connectionString)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(commonSupplier, dbContext, connectionString, dataBind);
            }

            return DataStoreInstance;
        }

        #endregion

        public IDataBind StoreDataBind
        {
            get { return _dataBind ?? (_dataBind = DataBind.Instance()); }
            set { _dataBind = value; }
        }

        public string StoreConnectionStringName
        {
            get { return _connectionString ?? (_connectionString = "name=ProjectDbContext"); }
            set { _connectionString = value; }
        }

        public IProjectDbContext StoreProjectDbContext
        {
            get { return _projectDbContext ?? (_projectDbContext = new ProjectDbContext(StoreConnectionStringName)); }
            set { _projectDbContext = value; }
        }

        public ISharingSupplier StoreSharingSupplier
        {
            get { return _sharingSupplier ?? (_sharingSupplier = SharingSupplier.Instance()); }
            set { _sharingSupplier = value; }
        }

        #region ENTITIES

        public IEntityA NewEntityA => new EntityA();

        public IEntityB NewEntityB => new EntityB();

        #endregion
    }
}