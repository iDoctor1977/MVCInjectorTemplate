﻿using System;
using Injector.Common.IABase;
using Injector.Common.IBind;
using Injector.Common.IFeature;
using Injector.Common.IStore;
using Injector.Common.IVModel;

namespace Injector.Business.Layers
{
    public class FeatureB : ABaseFeature, IFeatureB
    {
        private IABaseStep<IVMCreateB> _createStep1;
        private IABaseStep<IVMCreateB> _createStep2;
        private IABaseStep<IVMCreateB> _createStep3;

        private static IFeatureB FeatureBInstance { get; set; }

        #region CONSTRUCTOR

        private FeatureB() { }

        private FeatureB(ICoreStore coreStore) : base(coreStore) { }

        private FeatureB(ICoreBind coreBind) : base(coreBind) { }

        private FeatureB(ICoreStore coreStore, ICoreBind coreBind) : base(coreStore, coreBind) { }

        #endregion

        #region SINGLETON

        public static IFeatureB Instance()
        {
            if (FeatureBInstance == null)
            {
                FeatureBInstance = new FeatureB();
            }

            return FeatureBInstance;
        }

        public static IFeatureB Instance(ICoreStore coreStore)
        {
            if (FeatureBInstance == null)
            {
                FeatureBInstance = new FeatureB(coreStore);
            }

            return FeatureBInstance;
        }

        public static IFeatureB Instance(ICoreBind coreBind)
        {
            if (FeatureBInstance == null)
            {
                FeatureBInstance = new FeatureB(coreBind);
            }

            return FeatureBInstance;
        }

        public static IFeatureB Instance(ICoreStore coreStore, ICoreBind coreBind)
        {
            if (FeatureBInstance == null)
            {
                FeatureBInstance = new FeatureB(coreStore, coreBind);
            }

            return FeatureBInstance;
        }

        #endregion

        public bool CreatePost(IVMCreateB vmCreateB)
        {
            _createStep1 = ABaseStore.NewCreateBConcreteStep1;
            _createStep2 = ABaseStore.NewCreateBConcreteStep2;
            _createStep3 = ABaseStore.NewCreateBConcreteStep3;

            // chain definition
            _createStep1.SetNextStep(_createStep2);
            _createStep2.SetNextStep(_createStep3);

            _createStep1.Execute(vmCreateB);

            if (vmCreateB.DTOModelB.Id != Guid.Empty)
            {
                ABaseBind.BindDataSupplier.Commit();

                return true;
            }

            return false;
        }

        public IVMDeleteB DeleteGet(IVMDeleteB vmDeleteB)
        {
            // chain definition

            return vmDeleteB;
        }

        public bool DeletePost(IVMDeleteB vmDeleteB)
        {
            throw new System.NotImplementedException();
        }

        public IVMEditB EditGet(IVMEditB vmEditB)
        {
            throw new System.NotImplementedException();
        }

        public bool EditPost(IVMEditB vmEditB)
        {
            throw new System.NotImplementedException();
        }

        public IVMDetailsB DetailsGet(IVMDetailsB vmDetailsB)
        {
            throw new System.NotImplementedException();
        }

        public IVMListB ListGet(IVMListB vmListB)
        {
            throw new System.NotImplementedException();
        }
    }
}
