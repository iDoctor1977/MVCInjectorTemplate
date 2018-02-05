using Injector.Common.IABase;
using Injector.Common.IBond;

namespace Injector.Business
{
    public class ABaseCoreStore : IABaseCoreStore
    {
        private ICoreBond _coreBond;

        #region CONSTRUCTOR

        protected ABaseCoreStore() { }

        protected ABaseCoreStore(ICoreBond coreBond)
        {
            ABaseCoreBond = coreBond;
        }

        #endregion

        public ICoreBond ABaseCoreBond
        {
            get { return _coreBond ?? (_coreBond = CoreBond.Instance()); }
            set { _coreBond = value; }
        }
    }
}