using Injector.Common.ILogic;
using Injector.Common.ISupplier;

namespace Injector.Business
{
    public class BusinessSupplier : ICoreSupplier
    {
        private IOperatorA operatorA;
        private IOperatorB operatorB;

        public BusinessSupplier() { }

        public BusinessSupplier(IBusinessStore businessStore)
        {
            BusinessStore.InstanceOfBusinessStore = businessStore;
        }

        public IOperatorA GenerateOperatorA()
        {
            return operatorA ?? (operatorA = BusinessStore.InstanceOfBusinessStore.GetOperatorA());
        }

        public IOperatorB GenerateOperatorB()
        {
            return operatorB ?? (operatorB = BusinessStore.InstanceOfBusinessStore.GetOperatorB());
        }
    }
}