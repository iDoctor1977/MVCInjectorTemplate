using Injector.Common.DTOModel;
using Injector.Common.IABase;
using Injector.Common.IBond;

namespace Injector.Business.Step
{
    public abstract class ABaseStep : IABaseStep
    {
        private ICoreBond _coreBond;
        protected IABaseStep Successor { get; private set; }

        #region CONSTRUCTOR

        internal ABaseStep() { }

        internal ABaseStep(ICoreBond coreBond)
        {
            ABaseBond = coreBond;
        }

        #endregion

        public ICoreBond ABaseBond
        {
            get { return _coreBond ?? (_coreBond = CoreBond.Instance()); }
            set { _coreBond = value; }
        }

        public void SetSuccessor(IABaseStep step)
        {
            Successor = step;
        }

        public abstract ModelA HandleStep(ModelA modelA);
    }
}