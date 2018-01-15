using Injector.Common.IConverter;
using Injector.Common.IDbContext;
using Injector.Common.IEntity;
using Injector.Common.IStore;
using Injector.Data.ADOModel;

namespace Injector.Data
{
    internal class DataStore : IDataStore
    {
        private string _connectionString;
        private IProjectDbContext _projectDbContext;
        private ICommonSupplier _commonSupplier;

        private IEntityA _entityA;
        private IEntityB _entityB;

        private IConverterEntityA _converterEntityA;
        private IConverterEntityB _converterEntityB;
        private IProjectDbContext _getProjectDbContext;

        #region CONSTRUCTOR

        private DataStore() { }

        private DataStore(string connectionString)
        {
            ConnectionStringName = connectionString;

            if (DataStoreInstance == null)
            {
                DataStoreInstance = this;
            }
        }

        private DataStore(IProjectDbContext dbContext, string connectionString)
        {
            ProjectDbContext = dbContext;
            ConnectionStringName = connectionString;

            if (DataStoreInstance == null)
            {
                DataStoreInstance = this;
            }
        }

        private DataStore(ICommonSupplier commonSupplier)
        {
            CommonSupplier = commonSupplier;

            if (DataStoreInstance == null)
            {
                DataStoreInstance = this;
            }
        }

        private DataStore(ICommonSupplier commonSupplier, IProjectDbContext dbContext)
        {
            CommonSupplier = commonSupplier;
            ProjectDbContext = dbContext;

            if (DataStoreInstance == null)
            {
                DataStoreInstance = this;
            }
        }

        private DataStore(ICommonSupplier commonSupplier, IProjectDbContext dbContext, string connectionString)
        {
            CommonSupplier = commonSupplier;
            ProjectDbContext = dbContext;
            ConnectionStringName = connectionString;

            if (DataStoreInstance == null)
            {
                DataStoreInstance = this;
            }
        }

        #endregion

        #region SINGLETON

        private static IDataStore DataStoreInstance { get; set; }

        public static IDataStore Instance()
        {
            return DataStoreInstance = new DataStore();
        }

        public static IDataStore Instance(string connectionString)
        {
            return DataStoreInstance = new DataStore(connectionString);
        }

        public static IDataStore Instance(IProjectDbContext dbContext, string connectionString)
        {
            return DataStoreInstance = new DataStore(dbContext, connectionString);
        }

        public static IDataStore Instance(ICommonSupplier commonSupplier)
        {
            return DataStoreInstance = new DataStore(commonSupplier);
        }

        public static IDataStore Instance(ICommonSupplier commonSupplier, IProjectDbContext dbContext)
        {
            return DataStoreInstance = new DataStore(commonSupplier, dbContext);
        }

        public static IDataStore Instance(ICommonSupplier commonSupplier, IProjectDbContext dbContext, string connectionString)
        {
            return DataStoreInstance = new DataStore(commonSupplier, dbContext, connectionString);
        }

        #endregion

        public string ConnectionStringName
        {
            get { return _connectionString ?? (_connectionString = "name=ProjectDbContext"); }
            set { _connectionString = value; }
        }

        public IProjectDbContext ProjectDbContext
        {
            get { return _projectDbContext ?? (_projectDbContext = new ProjectDbContext(ConnectionStringName)); }
            set { _projectDbContext = value; }
        }

        public ICommonSupplier CommonSupplier
        {
            get { return _commonSupplier ?? (_commonSupplier = CommonSupplier.Instance()); }
            set { _commonSupplier = value; }
        }

        public IEntityA GetEntityA
        {
            get { return _entityA ?? (_entityA = new EntityA()); }
            set { _entityA = value as EntityA; }
        }

        public IEntityB GetEntityB
        {
            get { return _entityB ?? (_entityB = new EntityB()); }
            set { _entityB = value as EntityB; }
        }

        public IConverterEntityA NewConverterEntityA
        {
            get { return _converterEntityA ?? (_converterEntityA = new ConverterEntityA()); }
            set { _converterEntityA = value as ConverterEntityA; }
        }

        public IConverterEntityB NewConverterEntityB
        {
            get { return _converterEntityB ?? (_converterEntityB = new ConverterEntityB()); }
            set { _converterEntityB = value as ConverterEntityB; }
        }
    }
}