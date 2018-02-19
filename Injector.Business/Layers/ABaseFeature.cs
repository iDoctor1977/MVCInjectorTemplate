using Injector.Common.IABase;
using Injector.Common.IBind;
using Injector.Common.IStore;

namespace Injector.Business.Layers
{
    public class ABaseFeature : IABaseFeature
    {
        private ICoreBind _coreBind;
        private ICoreStore _coreStore;

        #region CONSTRUCTOR

        internal ABaseFeature() { }

        internal ABaseFeature(ICoreStore coreStore)
        {
            ABaseStore = coreStore;
        }

        internal ABaseFeature(ICoreBind coreBind)
        {
            ABaseBind = coreBind;
        }

        internal ABaseFeature(ICoreStore coreStore, ICoreBind coreBind)
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