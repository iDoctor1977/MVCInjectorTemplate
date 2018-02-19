using Injector.Common.IABase;
using Injector.Common.IFeature;
using Injector.Common.IStore;

namespace Injector.Business.Layer
{
    public abstract class ABaseLogic : IABaseLogic
    {
        private ICoreBond _coreBond;
        private ICoreStore _coreStore;

        #region CONSTRUCTOR

        internal ABaseLogic() { }

        internal ABaseLogic(ICoreStore coreStore)
        {
            ABaseStore = coreStore;
        }

        internal ABaseLogic(ICoreBond coreBond)
        {
            ABaseBond = coreBond;
        }

        internal ABaseLogic(ICoreStore coreStore, ICoreBond coreBond)
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