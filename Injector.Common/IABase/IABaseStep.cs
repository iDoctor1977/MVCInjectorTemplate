using Injector.Common.IBind;

namespace Injector.Common.IABase
{
    public interface IABaseStep<T>
    {
        ICoreBind ABaseBind { get; set; }

        void SetNextStep(IABaseStep<T> step);
        T Execute(T modelA);
    }
}