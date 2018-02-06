using Injector.Common.DTOModel;
using Injector.Common.IABase;
using Injector.Common.IBind;

namespace Injector.Business.Step
{
    public abstract class ABaseStep : IABaseStep
    {
        private ICoreBind _coreBind;
        protected IABaseStep Successor { get; private set; }

        #region CONSTRUCTOR

        internal ABaseStep() { }

        internal ABaseStep(ICoreBind coreBind)
        {
            ABaseBond = coreBind;
        }

        #endregion

        public ICoreBind ABaseBond
        {
            get { return _coreBind ?? (_coreBind = CoreBind.Instance()); }
            set { _coreBind = value; }
        }

        public void SetSuccessor(IABaseStep step)
        {
            Successor = step;
        }

        public abstract ModelA HandleStep(ModelA modelA);
    }
}