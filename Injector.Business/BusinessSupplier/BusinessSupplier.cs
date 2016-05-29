using Injector.Business.BusinessLayer;
using Injector.Common.IOperator;
using Injector.Common.ISupplier;

namespace Injector.Business.BusinessSupplier
{
    public class BusinessSupplier : IBusinessSupplier
    {
        private IOperatorA operatorA;
        private IOperatorB operatorB;

        public IOperatorA GenerateOperatorA()
        {
            return operatorA ?? (operatorA = new OperatorA());
        }

        public IOperatorB GenerateOperatorB()
        {
            return operatorB ?? (operatorB = new OperatorB());
        }
    }
}