using Injector.Common.IABase;
using Injector.Common.IBind;
using Injector.Common.IStore;

namespace Injector.Data
{
    public class ABaseDataSupplier : IABaseDataSupplier
    {
        private IDataBind _dataBind;
        private IDataStore _dataStore;

        #region CONSTRUCTOR

        internal ABaseDataSupplier() { }

        internal ABaseDataSupplier(IDataStore dataStore)
        {
            ABaseStore = dataStore;
        }

        internal ABaseDataSupplier(IDataBind dataBind)
        {
            ABaseBind = dataBind;
        }

        internal ABaseDataSupplier(IDataStore dataStore, IDataBind dataBind)
        {
            ABaseStore = dataStore;
            ABaseBind = dataBind;
        }

        #endregion

        public IDataBind ABaseBind
        {
            get { return _dataBind ?? (_dataBind = DataBind.Instance()); }
            set { _dataBind = value; }
        }

        public IDataStore ABaseStore
        {
            get { return _dataStore ?? (_dataStore = DataStore.Instance()); }
            set { _dataStore = value; }
        }
    }
}