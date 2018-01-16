using Injector.Common.ILogic;
using Injector.Common.ISupplier;

namespace Injector.Business
{
    public class CoreSupplier : ICoreSupplier
    {
        private IOperatorA operatorA;
        private IOperatorB operatorB;

        public CoreSupplier() { }

        public CoreSupplier(IBusinessStore businessStore)
        {
            CoreStore.InstanceOfBusinessStore = businessStore;
        }

        public IOperatorA GenerateOperatorA()
        {
            return operatorA ?? (operatorA = CoreStore.InstanceOfBusinessStore.GetOperatorA());
        }

        public IOperatorB GenerateOperatorB()
        {
            return operatorB ?? (operatorB = CoreStore.InstanceOfBusinessStore.GetOperatorB());
        }
    }
}