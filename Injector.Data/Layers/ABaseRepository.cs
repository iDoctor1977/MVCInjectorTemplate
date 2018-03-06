using Injector.Common.DTOModel;
using Injector.Common.IABase;
using Injector.Common.IEntity;
using Injector.Common.IStore;
using Injector.Data.ADOModel;

namespace Injector.Data.Layers
{
    public abstract class ABaseRepository : IABaseRepository
    {
        private IDataStore _dataStore;

        #region CONSTRUCTOR

        protected ABaseRepository() { }

        protected ABaseRepository(IDataStore dataStore)
        {
            ABaseDataStore = dataStore;
        }

        #endregion

        public IDataStore ABaseDataStore
        {
            get { return _dataStore ?? (_dataStore = DataStore.Instance()); }
            set { _dataStore = value; }
        }

        protected ProjectDbContext ABaseDbContext()
        {
            return ABaseDataStore.StoreProjectDbContext as ProjectDbContext;
        }

        protected void Commit()
        {
            ABaseDbContext().SaveChanges();
        }

        #region CONVERTER A

        public ModelA ConvertAEntityToModel(IEntityA entityA)
        {
            ModelA modelA = ABaseDataStore.StoreSharingSupplier.GetModelA() as ModelA;
            modelA.Id = entityA.Id;
            modelA.Name = entityA.Name;
            modelA.Surname = entityA.Surname;

            return modelA;
        }

        public IEntityA ConvertAModelToEntity(ModelA modelA)
        {
            EntityA entityA = ABaseDataStore.NewEntityA as EntityA;
            entityA.Id = modelA.Id;
            entityA.Name = modelA.Name;
            entityA.Surname = modelA.Surname;

            return entityA;
        }

        #endregion

        #region CONVERTER B

        public ModelB ConvertBEntityToModel(IEntityB entityB)
        {
            ModelB modelB = ABaseDataStore.StoreSharingSupplier.GetModelB() as ModelB;
            modelB.Id = entityB.Id;
            modelB.Username = entityB.Username;
            modelB.Email = entityB.Email;

            return modelB;
        }

        public IEntityB ConvertBModelToEntity(ModelB modelB)
        {
            EntityB entityB = ABaseDataStore.NewEntityB as EntityB;
            entityB.Id = modelB.Id;
            entityB.Username = modelB.Username;
            entityB.Email = modelB.Email;

            return entityB;
        }

        #endregion
    }
}
