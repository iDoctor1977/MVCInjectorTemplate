using Injector.Common.DTOModel;
using Injector.Common.IBind;

namespace Injector.Common.IABase
{
    public interface IABaseStep
    {
        ICoreBind ABaseBond { get; set; }

        void SetSuccessor(IABaseStep step);
        ModelA HandleStep(ModelA modelA);
    }
}