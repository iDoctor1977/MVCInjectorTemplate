using Injector.Common.DTOModel;
using Injector.Common.IABase;
using Injector.Common.IBind;

namespace Injector.Business.Steps.BSteps
{
    public abstract class ABaseStepB : IABaseStep<ModelB>
    {
        private ICoreBind _coreBind;
        protected IABaseStep<ModelB> NextStep { get; private set; }

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

        public void SetNextStep(IABaseStep<ModelB> nextStep)
        {
            NextStep = nextStep;
        }

        public abstract ModelB Execute(ModelB modelA);
    }
}