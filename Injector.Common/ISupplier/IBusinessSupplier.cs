using Injector.Common.IOperator;

namespace Injector.Common.ISupplier
{
    public interface IBusinessSupplier
    {
        IBusinessOperator GenerateBusinessOperator();
    }
}