using Injector.Business.Layer;
using Injector.Common;
using Injector.Common.ILogic;
using Injector.Common.IStore;
using Injector.Common.ISupplier;

namespace Injector.Business
{
    public class CoreSupplier : ABaseCoreSupplier, ICoreSupplier
    {
        private ILogicA _logicA;
        private ILogicB _logicB;

        #region CONSTRUCTOR

        public CoreSupplier() { }

        public CoreSupplier(ICoreStore coreStore) : base(coreStore) { }

        #endregion

        #region SINGLETON

        private static ICoreSupplier CoreSupplierInstance { get; set; }

        public static ICoreSupplier Instance()
        {
            if (CoreSupplierInstance == null)
            {
                CoreSupplierInstance = new CoreSupplier();
            }

            return CoreSupplierInstance;
        }

        public static ICoreSupplier Instance(ICoreStore coreStore)
        {
            if (CoreSupplierInstance == null)
            {
                CoreSupplierInstance = new CoreSupplier(coreStore);
            }

            return CoreSupplierInstance;
        }

        #endregion

        #region LOGICS

        public ILogicA GetLogicA => _logicA ?? (_logicA = LogicA.Instance(SupplierCoreStore)); // new LogicA()

        public ILogicB GetLogicB => _logicB ?? (_logicB = LogicB.Instance(SupplierCoreStore)); // new LogicB()

        #endregion
    }
}