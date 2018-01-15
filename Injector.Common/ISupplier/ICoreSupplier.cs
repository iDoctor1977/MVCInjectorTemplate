using Injector.Common.ILogic;

namespace Injector.Common.ISupplier
{
    public interface ICoreSupplier
    {
        IOperatorA GenerateOperatorA();
        IOperatorB GenerateOperatorB();
    }
}