using Injector.Common.IABase;
using Injector.Common.IStore;

namespace Injector.Data
{
    public class ABaseDataSupplier : IABaseDataSupplier
    {
        private IDataStore _dataStore;

        #region CONSTRUCTOR

        internal ABaseDataSupplier() { }

        internal ABaseDataSupplier(IDataStore dataStore)
        {
            SupplierDataStore = dataStore;
        }

        #endregion

        public IDataStore SupplierDataStore
        {
            get { return _dataStore ?? (_dataStore = DataStore.Instance()); }
            set { _dataStore = value; }
        }
    }
}