using System;
using Injector.Common.IFeature;
using Injector.Common.IStore;
using Injector.Common.IVModel;

namespace Injector.Business.Feature
{
    public class FeatureModelA : ABaseFeatureModelA, IFeatureModelA
    {
        private IABaseStep _createStep1;
        private IABaseStep _createStep2;
        private IABaseStep _createStep3;

        private IABaseStep _deleteStep1;
        private IABaseStep _deleteStep2;


        #region CONSTRUCTOR

        public FeatureModelA() { }

        public FeatureModelA(ICoreStore coreStore) : base(coreStore) { }

        #endregion

        public bool CreatePost(IVMCreateA vmCreateA)
        {
            _createStep1 = new CreateAConcreteStep1(ABaseStore);
            _createStep2 = new CreateAConcreteStep2(ABaseStore);
            _createStep3 = new CreateAConcreteStep3(ABaseStore);

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
            _deleteStep1 = new DeleteAConcreteStep1(ABaseStore);
            _deleteStep2 = new DeleteAConcreteStep2(ABaseStore);

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
