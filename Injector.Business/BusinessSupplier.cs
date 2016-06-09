using Injector.Common.IOperator;
using Injector.Common.ISupplier;

namespace Injector.Business
{
    public class BusinessSupplier : IBusinessSupplier
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