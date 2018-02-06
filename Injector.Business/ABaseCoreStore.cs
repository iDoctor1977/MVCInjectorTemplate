using Injector.Common.IABase;
using Injector.Common.IBind;

namespace Injector.Business
{
    public class ABaseCoreStore : IABaseCoreStore
    {
        private ICoreBind _coreBind;

        #region CONSTRUCTOR

        protected ABaseCoreStore() { }

        protected ABaseCoreStore(ICoreBind coreBind)
        {
            ABaseCoreBind = coreBind;
        }

        #endregion

        public ICoreBind ABaseCoreBind
        {
            get { return _coreBind ?? (_coreBind = CoreBind.Instance()); }
            set { _coreBind = value; }
        }
    }
}