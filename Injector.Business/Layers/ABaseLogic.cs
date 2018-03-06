using Injector.Common.IABase;
using Injector.Common.IBind;
using Injector.Common.IStore;

namespace Injector.Business.Layers
{
    public abstract class ABaseLogic : IABaseLogic
    {
        private ICoreBind _coreBind;
        private ICoreStore _coreStore;

        #region CONSTRUCTOR

        internal ABaseLogic() { }

        internal ABaseLogic(ICoreStore coreStore)
        {
            ABaseStore = coreStore;
        }

        internal ABaseLogic(ICoreBind coreBond)
        {
            ABaseBind = coreBond;
        }

        internal ABaseLogic(ICoreStore coreStore, ICoreBind coreBond)
        {
            ABaseStore = coreStore;
            ABaseBind = coreBond;
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