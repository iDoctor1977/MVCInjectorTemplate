using Injector.Common.IABase;
using Injector.Common.IStore;

namespace Injector.Data.Converter
{
    public class AConvBase : IAConvBase
    {
        private IDataStore _dataStore;

        #region CONSTRUCTOR

        protected AConvBase()
        {
        }

        protected AConvBase(IDataStore dataStore)
        {
            AConvBaseDataStore = dataStore;
        }

        #endregion

        public IDataStore AConvBaseDataStore
        {
            get { return _dataStore ?? (_dataStore = DataStore.Instance()); }
            set { _dataStore = value; }
        }
    }
}
