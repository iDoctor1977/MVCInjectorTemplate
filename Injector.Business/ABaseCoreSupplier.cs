using Injector.Common.IABase;
using Injector.Common.IBond;
using Injector.Common.IStore;

namespace Injector.Business
{
    public abstract class ABaseCoreSupplier : IABaseCoreSupplier
    {
        private ICoreBond _coreBond;
        private ICoreStore _coreStore;

        #region CONSTRUCTOR

        internal ABaseCoreSupplier() { }

        internal ABaseCoreSupplier(ICoreStore coreStore)
        {
            ABaseStore = coreStore;
        }

        internal ABaseCoreSupplier(ICoreBond coreBond)
        {
            ABaseBond = coreBond;
        }

        internal ABaseCoreSupplier(ICoreStore coreStore, ICoreBond coreBond)
        {
            ABaseStore = coreStore;
            ABaseBond = coreBond;
        }

        #endregion

        public ICoreBond ABaseBond
        {
            get { return _coreBond ?? (_coreBond = CoreBond.Instance()); }
            set { _coreBond = value; }
        }

        public ICoreStore ABaseStore
        {
            get { return _coreStore ?? (_coreStore = CoreStore.Instance()); }
            set { _coreStore = value; }
        }
    }
}