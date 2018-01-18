using Injector.Common.DTOModel;
using Injector.Common.IABase;
using Injector.Common.IDbContext;
using Injector.Common.IEntity;
using Injector.Common.IStore;
using Injector.Data.ADOModel;
using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Injector.Data.Layer
{
    public abstract class ABaseRepository : IABaseRepository
    {
        private IDataStore _dataStore;

        #region CONSTRUCTOR

        protected ABaseRepository()
        {
        }

        protected ABaseRepository(IDataStore dataStore)
        {
            ABaseStore = dataStore;
        }

        #endregion

        public IDataStore ABaseStore
        {
            get { return _dataStore ?? (_dataStore = DataStore.Instance()); }
            set { _dataStore = value; }
        }

        protected ProjectDbContext ABaseDbContext()
        {
            return ABaseStore.StoreProjectDbContext as ProjectDbContext;
        }

        protected void Commit()
        {
            ABaseDbContext().SaveChanges();
        }

        #region CONVERTERS

        public ModelA ConvertAEntityToModel(IEntityA entityA)
        {
            ModelA modelA = ABaseStore.StoreCommonSupplier.GetModelA() as ModelA;
            modelA.Id = entityA.Id;
            modelA.Name = entityA.Name;
            modelA.Surname = entityA.Surname;

            return modelA;
        }

        public IEntityA ConvertAModelToEntity(ModelA modelA)
        {
            EntityA entityA = ABaseStore.NewEntityA as EntityA;
            entityA.Id = modelA.Id;
            entityA.Name = modelA.Name;
            entityA.Surname = modelA.Surname;

            return entityA;
        }

        public ModelB ConvertBEntityToModel(IEntityB entityB)
        {
            ModelB modelB = ABaseStore.StoreCommonSupplier.GetModelB() as ModelB;
            modelB.Id = entityB.Id;
            modelB.Username = entityB.Username;
            modelB.Email = entityB.Email;

            return modelB;
        }

        public IEntityB ConvertBModelToEntity(ModelB modelB)
        {
            return new ModelB
            {
                Id = modelB.Id,
                Username = modelB.Username,
                Email = modelB.Email
            };
        }

        #endregion
    }
}
