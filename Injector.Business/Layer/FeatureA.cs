using System;
using Injector.Common.IABase;
using Injector.Common.IBond;
using Injector.Common.IFeature;
using Injector.Common.IStore;
using Injector.Common.IVModel;

namespace Injector.Business.Layer
{
    public class FeatureA : ABaseFeature, IFeatureA
    {
        private IABaseStep _createStep1;
        private IABaseStep _createStep2;
        private IABaseStep _createStep3;

        private IABaseStep _deleteStep1;
        private IABaseStep _deleteStep2;

        private static IFeatureA FeatureAInstance { get; set; }

        #region CONSTRUCTOR

        private FeatureA() { }

        private FeatureA(ICoreStore coreStore) : base(coreStore) { }

        private FeatureA(ICoreBond coreBond) : base(coreBond) { }

        private FeatureA(ICoreStore coreStore, ICoreBond coreBond) : base(coreStore, coreBond) { }

        #endregion

        #region SINGLETON

        public static IFeatureA Instance()
        {
            if (FeatureAInstance == null)
            {
                FeatureAInstance = new FeatureA();
            }

            return FeatureAInstance;
        }

        public static IFeatureA Instance(ICoreStore coreStore)
        {
            if (FeatureAInstance == null)
            {
                FeatureAInstance = new FeatureA(coreStore);
            }

            return FeatureAInstance;
        }

        public static IFeatureA Instance(ICoreBond coreBond)
        {
            if (FeatureAInstance == null)
            {
                FeatureAInstance = new FeatureA(coreBond);
            }

            return FeatureAInstance;
        }

        public static IFeatureA Instance(ICoreStore coreStore, ICoreBond coreBond)
        {
            if (FeatureAInstance == null)
            {
                FeatureAInstance = new FeatureA(coreStore, coreBond);
            }

            return FeatureAInstance;
        }

        #endregion

        public bool CreatePost(IVMCreateA vmCreateA)
        {
            _createStep1 = ABaseStore.NewCreateAConcreteStep1;
            _createStep2 = ABaseStore.NewCreateAConcreteStep2;
            _createStep3 = ABaseStore.NewCreateAConcreteStep3;

            // chain definition
            _createStep1.SetSuccessor(_createStep2);
            _createStep2.SetSuccessor(_createStep3);

            vmCreateA.DTOModelA = _createStep1.HandleStep(vmCreateA.DTOModelA);

            if (vmCreateA.DTOModelA.Id != Guid.Empty)
            {
                return true;
            }

            return false;
        }

        public IVMDeleteA DeleteGet(IVMDeleteA vmDeleteA)
        {
            _deleteStep1 = ABaseStore.NewDeleteAConcreteStep1;
            _deleteStep2 = ABaseStore.NewDeleteAConcreteStep2;

            _deleteStep1.SetSuccessor(_deleteStep2);

            vmDeleteA.DTOModelA = _deleteStep1.HandleStep(vmDeleteA.DTOModelA);

            return vmDeleteA;
        }

        public bool DeletePost(IVMDeleteA vmDeleteA)
        {
            throw new System.NotImplementedException();
        }

        public IVMEditA EditGet(IVMEditA vmEditA)
        {
            throw new System.NotImplementedException();
        }

        public bool EditPost(IVMEditA vmEditA)
        {
            throw new System.NotImplementedException();
        }

        public IVMDetailsA DetailsGet(IVMDetailsA vmDetailsA)
        {
            throw new System.NotImplementedException();
        }

        public IVMListA ListGet(IVMListA vmListA)
        {
            throw new System.NotImplementedException();
        }
    }
}
