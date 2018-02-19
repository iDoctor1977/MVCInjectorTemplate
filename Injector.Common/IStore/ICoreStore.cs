using Injector.Common.DTOModel;
using Injector.Common.IABase;

namespace Injector.Common.IStore
{
    public interface ICoreStore
    {
        #region FEATURE STEPS A

        IABaseStep<ModelA> NewCreateAConcreteStep1 { get; }
        IABaseStep<ModelA> NewCreateAConcreteStep2 { get; }
        IABaseStep<ModelA> NewCreateAConcreteStep3 { get; }

        IABaseStep<ModelA> NewDeleteAConcreteStep1 { get; }
        IABaseStep<ModelA> NewDeleteAConcreteStep2 { get; }

        #endregion

        #region FEATURE STEPS B

        IABaseStep<ModelB> NewCreateBConcreteStep1 { get; }
        IABaseStep<ModelB> NewCreateBConcreteStep2 { get; }
        IABaseStep<ModelB> NewCreateBConcreteStep3 { get; }

        #endregion
    }
}