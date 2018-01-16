using Injector.Common.IDbContext;
using Injector.Common.IStore;
using Injector.Data.ADOModel;

namespace Injector.Data.Layer
{
    public abstract class ARBase : IARBase
    {
        private IDataStore _dataStore;

        #region CONSTRUCTOR

        protected ARBase()
        {
        }

        protected ARBase(IDataStore dataStore)
        {
            ARBaseDataStore = dataStore;
        }

        #endregion

        public IDataStore ARBaseDataStore
        {
            get { return _dataStore ?? (_dataStore = DataStore.Instance()); }
            set { _dataStore = value; }
        }

        protected IProjectDbContext ARBaseDbContext()
        {
            return ARBaseDataStore.DStoreProjectDbContext as ProjectDbContext;
        }

        public void Commit()
        {
            ARBaseDbContext().SaveChanges();
        }
    }

    public interface IARBase
    {
    }
}
