using Injector.Common.ILogic;
using Injector.Common.ISupplier;

namespace Injector.Business
{
    public class CoreSupplier : ICoreSupplier
    {
        private IOperatorA operatorA;
        private IOperatorB operatorB;

        public CoreSupplier() { }

        public CoreSupplier(ICoreStore businessStore)
        {
            CoreStore.CoreStoreInstance = businessStore;
        }

        public IOperatorA GenerateOperatorA()
        {
            return operatorA ?? (operatorA = CoreStore.CoreStoreInstance.GetOperatorA());
        }

        public IOperatorB GenerateOperatorB()
        {
            return operatorB ?? (operatorB = CoreStore.CoreStoreInstance.GetOperatorB());
        }
    }
}