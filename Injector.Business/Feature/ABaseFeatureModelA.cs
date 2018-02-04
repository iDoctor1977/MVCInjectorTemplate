using Injector.Common.IFeature;
using Injector.Common.IStore;

namespace Injector.Business.Feature
{
    public class ABaseFeatureModelA : IABaseFeatureModelA
    {
        private ICoreStore _coreStore;

        #region CONSTRUCTOR

        protected ABaseFeatureModelA() { }

        protected ABaseFeatureModelA(ICoreStore coreStore)
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