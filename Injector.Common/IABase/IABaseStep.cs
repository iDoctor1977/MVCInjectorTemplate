using Injector.Common.DTOModel;
using Injector.Common.IBond;

namespace Injector.Common.IABase
{
    public interface IABaseStep
    {
        ICoreBond ABaseBond { get; set; }

        void SetSuccessor(IABaseStep step);
        ModelA HandleStep(ModelA modelA);
    }
}