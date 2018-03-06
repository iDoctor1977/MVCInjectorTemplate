using Injector.Common.IBind;
using Injector.Common.IVModel;

namespace Injector.Common.IABase
{
    public interface IABaseStep<T>
    {
        ICoreBind ABaseBind { get; set; }

        void SetNextStep(IABaseStep<T> step);
        T Execute(T vmCreateB);
    }
}