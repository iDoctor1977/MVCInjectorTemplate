using Injector.Common.DTOModel;
using Injector.Common.IFeature;
using Injector.Common.IStore;

namespace Injector.Business.Feature
{
    public abstract class ABaseStep : IABaseStep
    {
        private ICoreStore _coreStore;
        protected IABaseStep Successor { get; private set; }

        #region CONSTRUCTOR

        protected ABaseStep() { }

        protected ABaseStep(ICoreStore coreStore)
        {
            ABaseStore = coreStore;
        }

        #endregion

        public ICoreStore ABaseStore
        {
            get { return _coreStore ?? (_coreStore = CoreStore.Instance()); }
            set { _coreStore = value; }
        }

        public void SetSuccessor(IABaseStep step)
        {
            Successor = step;
        }

        public abstract ModelA HandleStep(ModelA modelA);

        protected abstract ModelA Read(ModelA modelA);
        protected abstract void Do(ModelA modelA);
        protected abstract void Write(ModelA modelA);
    }
}