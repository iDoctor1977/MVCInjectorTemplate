using Injector.Business.Layers;
using Injector.Common.IFeature;
using Injector.Common.ILogic;
using Injector.Common.IStore;
using Injector.Common.ISupplier;

namespace Injector.Business
{
    public class CoreSupplier : ABaseCoreSupplier, ICoreSupplier
    {
        private IFeatureA _featureA;
        private IFeatureB _featureB;

        private ILogicA _logicA;

        #region CONSTRUCTOR

        public CoreSupplier() { }

        public CoreSupplier(ICoreStore coreStore) : base(coreStore) { }

        #endregion

        #region SINGLETON

        private static ICoreSupplier CoreSupplierInstance { get; set; }

        public static ICoreSupplier Instance()
        {
            if (CoreSupplierInstance == null)
            {
                CoreSupplierInstance = new CoreSupplier();
            }

            return CoreSupplierInstance;
        }

        public static ICoreSupplier Instance(ICoreStore coreStore)
        {
            if (CoreSupplierInstance == null)
            {
                CoreSupplierInstance = new CoreSupplier(coreStore);
            }

            return CoreSupplierInstance;
        }

        #endregion

        #region FEATURES

        public IFeatureA GetFeatureA => _featureA ?? (_featureA = FeatureA.Instance(ABaseStore, ABaseBind)); // new FeatureA()
        public IFeatureB GetFeatureB => _featureB ?? (_featureB = FeatureB.Instance(ABaseStore, ABaseBind)); // new FeatureB()

        #endregion

        #region LOGICS

        public ILogicA GetLogicA => _logicA ?? (_logicA = LogicA.Instance(ABaseStore, ABaseBind)); // new LogicC()

        #endregion
    }
}