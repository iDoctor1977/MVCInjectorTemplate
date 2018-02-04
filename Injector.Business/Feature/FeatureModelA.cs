using System;
using Injector.Common.IFeature;
using Injector.Common.IVModel;

namespace Injector.Business.Feature
{
    public class FeatureModelA : ABaseFeatureModelA, IFeatureModelA
    {
        private IABaseStep _step1;
        private IABaseStep _step2;
        private IABaseStep _step3;

        public bool CreatePost(IVMCreateA vmCreateA)
        {
            _step1 = ABaseStore.NewConcreteAStep1;
            _step2 = ABaseStore.NewConcreteAStep2;
            _step3 = ABaseStore.NewConcreteAStep3;

            // chain definition
            _step1.SetSuccessor(_step2);
            _step2.SetSuccessor(_step3);

            vmCreateA.DTOModelA = _step1.HandleStep(vmCreateA.DTOModelA);

            if (vmCreateA.DTOModelA.Id != Guid.Empty)
            {
                return true;
            }

            return false;
        }

        public IVMDeleteA DeleteGet(IVMDeleteA vmDeleteA)
        {
            throw new System.NotImplementedException();
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
