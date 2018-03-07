using Injector.Common.DTOModel;
using Injector.Common.IABase;
using Injector.Common.IStore;
using Injector.Data.ADOModel;

namespace Injector.Data.Layer
{
    public abstract class ABaseRepository : IABaseRepository
    {
        private IDataStore _dataStore;

        #region CONSTRUCTOR

        protected ABaseRepository() { }

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
    }
}
