using Injector.Common.IABase;
using Injector.Common.IStore;

namespace Injector.Business.Layer
{
    public abstract class ABaseLogic : IABaseLogic
    {
        private ICoreStore _coreStore;

        #region CONSTRUCTOR

        protected ABaseLogic() { }

        protected ABaseLogic(ICoreStore coreStore)
        {
            ABaseStore = coreStore;
        }

        #endregion

        public ICoreStore ABaseStore
        {
            get { return _coreStore ?? (_coreStore = CoreStore.Instance()); }
            set { _coreStore = value; }
        }
    }
}