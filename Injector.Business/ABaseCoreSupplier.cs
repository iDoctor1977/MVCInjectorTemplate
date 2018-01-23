using Injector.Common.IABase;
using Injector.Common.IStore;

namespace Injector.Business
{
    public abstract class ABaseCoreSupplier : IABaseCoreSupplier
    {
        private ICoreStore _coreStore;

        #region CONSTRUCTOR

        internal ABaseCoreSupplier() { }

        internal ABaseCoreSupplier(ICoreStore coreStore)
        {
            SupplierCoreStore = coreStore;
        }

        #endregion

        public ICoreStore SupplierCoreStore
        {
            get { return _coreStore ?? (_coreStore = CoreStore.Instance()); }
            set { _coreStore = value; }
        }
    }
}