using Injector.Business.Layers;
using Injector.Common.IBind;
using Injector.Common.IFeature;
using Injector.Common.IStore;
using Injector.Common.ISupplier;

namespace Injector.Business
{
    public class CoreSupplier : ABaseCoreSupplier, ICoreSupplier
    {
        private IFeatureA _featureA;
        private IFeatureB _featureB;

        #region CONSTRUCTOR

        public CoreSupplier() { }

        public CoreSupplier(ICoreStore coreStore) : base(coreStore) { }

        public CoreSupplier(ICoreBind coreBind) : base(coreBind) { }

        public CoreSupplier(ICoreStore coreStore, ICoreBind coreBind) : base(coreStore, coreBind) { }

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

        public static ICoreSupplier Instance(ICoreBind coreBind)
        {
            if (CoreSupplierInstance == null)
            {
                CoreSupplierInstance = new CoreSupplier(coreBind);
            }

            return CoreSupplierInstance;
        }

        public static ICoreSupplier Instance(ICoreStore coreStore, ICoreBind coreBind)
        {
            if (CoreSupplierInstance == null)
            {
                CoreSupplierInstance = new CoreSupplier(coreStore, coreBind);
            }

            return CoreSupplierInstance;
        }

        #endregion

        #region FEATURES

        public IFeatureA GetFeatureA => _featureA ?? (_featureA = FeatureA.Instance(ABaseStore, ABaseBind)); // new FeatureA()
        public IFeatureB GetFeatureB => _featureB ?? (_featureB = FeatureB.Instance(ABaseStore, ABaseBind)); // new FeatureB()

        #endregion
    }
}