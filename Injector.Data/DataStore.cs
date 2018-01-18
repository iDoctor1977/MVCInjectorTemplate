﻿using Injector.Common;
using Injector.Common.IDbContext;
using Injector.Common.IEntity;
using Injector.Common.IStore;
using Injector.Common.ISupplier;
using Injector.Data.ADOModel;

namespace Injector.Data
{
    internal class DataStore : IDataStore
    {
        private string _connectionString;
        private IProjectDbContext _projectDbContext;
        private ISharingSupplier _sharingSupplier;

        private IEntityA _entityA;
        private IEntityB _entityB;

        #region CONSTRUCTOR

        private DataStore() { }

        private DataStore(string connectionString)
        {
            StoreConnectionStringName = connectionString;
        }

        private DataStore(IProjectDbContext dbContext, string connectionString)
        {
            StoreProjectDbContext = dbContext;
            StoreConnectionStringName = connectionString;
        }

        private DataStore(ISharingSupplier commonSupplier)
        {
            StoreCommonSupplier = commonSupplier;
        }

        private DataStore(ISharingSupplier commonSupplier, IProjectDbContext dbContext)
        {
            StoreCommonSupplier = commonSupplier;
            StoreProjectDbContext = dbContext;
        }

        private DataStore(ISharingSupplier commonSupplier, IProjectDbContext dbContext, string connectionString)
        {
            StoreCommonSupplier = commonSupplier;
            StoreProjectDbContext = dbContext;
            StoreConnectionStringName = connectionString;
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

        public static IDataStore Instance(string connectionString)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(connectionString);
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

        public static IDataStore Instance(ISharingSupplier commonSupplier)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(commonSupplier);
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

        public static IDataStore Instance(ISharingSupplier commonSupplier, IProjectDbContext dbContext, string connectionString)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(commonSupplier, dbContext, connectionString);
            }

            return DataStoreInstance;
        }

        #endregion

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

        public ISharingSupplier StoreCommonSupplier
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
    }
}