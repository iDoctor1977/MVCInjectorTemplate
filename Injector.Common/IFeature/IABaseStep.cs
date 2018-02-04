using Injector.Common.DTOModel;
using Injector.Common.IStore;

namespace Injector.Common.IFeature
{
    public interface IABaseStep
    {
        ICoreStore ABaseStore { get; set; }

        void SetSuccessor(IABaseStep step);
        ModelA HandleStep(ModelA modelA);
    }
}