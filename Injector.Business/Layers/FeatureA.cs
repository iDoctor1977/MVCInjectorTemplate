﻿using System;
using Injector.Common.IABase;
using Injector.Common.IBind;
using Injector.Common.IFeature;
using Injector.Common.IStore;
using Injector.Common.IVModel;

namespace Injector.Business.Layers
{
    public class FeatureA : ABaseFeature, IFeatureA
    {
        private IABaseStep<IVMCreateA> _createStep1;
        private IABaseStep<IVMCreateA> _createStep2;
        private IABaseStep<IVMCreateA> _createStep3;

        private IABaseStep<IVMDeleteA> _deleteStep1;
        private IABaseStep<IVMDeleteA> _deleteStep2;

        private static IFeatureA FeatureAInstance { get; set; }

        #region CONSTRUCTOR

        private FeatureA() { }

        private FeatureA(ICoreStore coreStore) : base(coreStore) { }

        private FeatureA(ICoreBind coreBind) : base(coreBind) { }

        private FeatureA(ICoreStore coreStore, ICoreBind coreBind) : base(coreStore, coreBind) { }

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

        public static IFeatureA Instance(ICoreBind coreBind)
        {
            if (FeatureAInstance == null)
            {
                FeatureAInstance = new FeatureA(coreBind);
            }

            return FeatureAInstance;
        }

        public static IFeatureA Instance(ICoreStore coreStore, ICoreBind coreBind)
        {
            if (FeatureAInstance == null)
            {
                FeatureAInstance = new FeatureA(coreStore, coreBind);
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
            _createStep1.SetNextStep(_createStep2);
            _createStep2.SetNextStep(_createStep3);

            vmCreateA = _createStep1.Execute(vmCreateA);

            if (vmCreateA.DTOModelA.Id != Guid.Empty)
            {
                ABaseBind.BindDataSupplier.Commit();

                return true;
            }

            return false;
        }

        public IVMDeleteA DeleteGet(IVMDeleteA vmDeleteA)
        {
            _deleteStep1 = ABaseStore.NewDeleteAConcreteStep1;
            _deleteStep2 = ABaseStore.NewDeleteAConcreteStep2;

            _deleteStep1.SetNextStep(_deleteStep2);

            vmDeleteA = _deleteStep1.Execute(vmDeleteA);

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
