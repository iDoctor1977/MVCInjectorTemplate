using Injector.Common.IABase;

namespace Injector.Common.IStore
{
    public interface ICoreStore
    {
        IABaseStep NewCreateAConcreteStep1 { get; }
        IABaseStep NewCreateAConcreteStep2 { get; }
        IABaseStep NewCreateAConcreteStep3 { get; }

        IABaseStep NewDeleteAConcreteStep1 { get; }
        IABaseStep NewDeleteAConcreteStep2 { get; }
    }
}