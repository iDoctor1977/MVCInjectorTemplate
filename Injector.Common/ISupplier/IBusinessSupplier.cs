using Injector.Common.IOperator;

namespace Injector.Common.ISupplier
{
    public interface IBusinessSupplier
    {
        IOperatorA GenerateOperatorA();
        IOperatorB GenerateOperatorB();
    }
}