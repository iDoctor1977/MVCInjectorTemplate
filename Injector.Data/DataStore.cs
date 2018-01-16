using Injector.Common;
using Injector.Common.IConverter;
using Injector.Common.IDbContext;
using Injector.Common.IEntity;
using Injector.Common.IStore;
using Injector.Common.ISupplier;
using Injector.Data.ADOModel;
using Injector.Data.Converter;

namespace Injector.Data
{
    internal class DataStore : IDataStore
    {
        private string _connectionString;
        private IProjectDbContext _projectDbContext;
        private ISharingSupplier _sharingSupplier;

        private IEntityA _entityA;
        private IEntityB _entityB;

        private IConverterA _converterA;
        private IConverterB _converterB;

        #region CONSTRUCTOR

        private DataStore()
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = this;
            }
        }

        private DataStore(string connectionString)
        {
            DStoreConnectionStringName = connectionString;

            if (DataStoreInstance == null)
            {
                DataStoreInstance = this;
            }
        }

        private DataStore(IProjectDbContext dbContext, string connectionString)
        {
            DStoreProjectDbContext = dbContext;
            DStoreConnectionStringName = connectionString;

            if (DataStoreInstance == null)
            {
                DataStoreInstance = this;
            }
        }

        private DataStore(ISharingSupplier commonSupplier)
        {
            DStoreCommonSupplier = commonSupplier;

            if (DataStoreInstance == null)
            {
                DataStoreInstance = this;
            }
        }

        private DataStore(ISharingSupplier commonSupplier, IProjectDbContext dbContext)
        {
            DStoreCommonSupplier = commonSupplier;
            DStoreProjectDbContext = dbContext;

            if (DataStoreInstance == null)
            {
                DataStoreInstance = this;
            }
        }

        private DataStore(ISharingSupplier commonSupplier, IProjectDbContext dbContext, string connectionString)
        {
            DStoreCommonSupplier = commonSupplier;
            DStoreProjectDbContext = dbContext;
            DStoreConnectionStringName = connectionString;

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

        public static IDataStore Instance(ISharingSupplier commonSupplier)
        {
            return DataStoreInstance = new DataStore(commonSupplier);
        }

        public static IDataStore Instance(ISharingSupplier commonSupplier, IProjectDbContext dbContext)
        {
            return DataStoreInstance = new DataStore(commonSupplier, dbContext);
        }

        public static IDataStore Instance(ISharingSupplier commonSupplier, IProjectDbContext dbContext, string connectionString)
        {
            return DataStoreInstance = new DataStore(commonSupplier, dbContext, connectionString);
        }

        #endregion

        public string DStoreConnectionStringName
        {
            get { return _connectionString ?? (_connectionString = "name=ProjectDbContext"); }
            set { _connectionString = value; }
        }

        public IProjectDbContext DStoreProjectDbContext
        {
            get { return _projectDbContext ?? (_projectDbContext = new ProjectDbContext(DStoreConnectionStringName)); }
            set { _projectDbContext = value; }
        }

        public ISharingSupplier DStoreCommonSupplier
        {
            get { return _sharingSupplier ?? (_sharingSupplier = SharingSupplier.Instance()); }
            set { _sharingSupplier = value; }
        }

        #region ENTITIES

        public IEntityA NewEntityA
        {
            get { return _entityA ?? (_entityA = new EntityA()); }
            set { _entityA = value as EntityA; }
        }

        public IEntityB NewEntityB
        {
            get { return _entityB ?? (_entityB = new EntityB()); }
            set { _entityB = value as EntityB; }
        }

        #endregion

        #region CONVERTERS

        public IConverterA NewConverterA
        {
            get { return _converterA ?? (_converterA = new ConverterA()); }
            set { _converterA = value as ConverterA; }
        }

        public IConverterB NewConverterB
        {
            get { return _converterB ?? (_converterB = new ConverterB()); }
            set { _converterB = value as ConverterB; }
        }

        #endregion
    }
}