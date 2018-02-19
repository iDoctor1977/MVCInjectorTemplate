using Injector.Common.DTOModel;
using Injector.Common.IABase;
using Injector.Common.IBind;

namespace Injector.Business.Steps.ASteps
{
    public abstract class ABaseStepA : IABaseStep<ModelA>
    {
        private ICoreBind _coreBind;
        protected IABaseStep<ModelA> NextStep { get; private set; }

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

        public void SetNextStep(IABaseStep<ModelA> nextStep)
        {
            NextStep = nextStep;
        }

        public abstract ModelA Execute(ModelA modelA);
    }
}