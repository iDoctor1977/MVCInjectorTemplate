using Injector.Common.IABase;
using Injector.Common.IBind;

namespace Injector.Business.Steps.ASteps
{
    public abstract class ABaseStepA<T> : IABaseStep<T>
    {
        private ICoreBind _coreBind;
        protected IABaseStep<T> NextStep { get; private set; }

        #region CONSTRUCTOR

        internal ABaseStepA() { }

        internal ABaseStepA(ICoreBind coreBind)
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

        public abstract T Execute(T viewModelA);
    }
}