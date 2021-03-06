﻿using Injector.Common.IABase;
using Injector.Common.IBind;
using Injector.Common.IVModel;

namespace Injector.Business.Steps.BSteps
{
    public abstract class ABaseStepB<T> : IABaseStep<T>
    {
        private ICoreBind _coreBind;
        protected IABaseStep<T> NextStep { get; private set; }

        #region CONSTRUCTOR

        internal ABaseStepB() { }

        internal ABaseStepB(ICoreBind coreBind)
        {
            ABaseBind = coreBind;
        }

        #endregion

        public ICoreBind ABaseBind
        {
            get { return _coreBind ?? (_coreBind = CoreBind.Instance()); }
            set { _coreBind = value; }
        }

        public void SetNextStep(IABaseStep<T> nextStep)
        {
            NextStep = nextStep;
        }

        public abstract T Execute(T viewModelB);
    }
}