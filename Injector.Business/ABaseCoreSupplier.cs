using Injector.Common.IABase;
using Injector.Common.IBind;
using Injector.Common.IStore;

namespace Injector.Business
{
    public abstract class ABaseCoreSupplier : IABaseCoreSupplier
    {
        private ICoreBind _coreBind;
        private ICoreStore _coreStore;

        #region CONSTRUCTOR

        internal ABaseCoreSupplier() { }

        internal ABaseCoreSupplier(ICoreStore coreStore)
        {
            ABaseStore = coreStore;
        }

        internal ABaseCoreSupplier(ICoreBind coreBind)
        {
            ABaseBind = coreBind;
        }

        internal ABaseCoreSupplier(ICoreStore coreStore, ICoreBind coreBind)
        {
            ABaseStore = coreStore;
            ABaseBind = coreBind;
        }

        #endregion

        public ICoreBind ABaseBind
        {
            get { return _coreBind ?? (_coreBind = CoreBind.Instance()); }
            set { _coreBind = value; }
        }

        public ICoreStore ABaseStore
        {
            get { return _coreStore ?? (_coreStore = CoreStore.Instance()); }
            set { _coreStore = value; }
        }
    }
}