using Injector.Common.DTOModel;
using Injector.Common.IABase;
using Injector.Common.IVModel;

namespace Injector.Common.IStore
{
    public interface ICoreStore
    {
        #region FEATURE STEPS A

        IABaseStep<IVMCreateA> NewCreateAConcreteStep1 { get; }
        IABaseStep<IVMCreateA> NewCreateAConcreteStep2 { get; }
        IABaseStep<IVMCreateA> NewCreateAConcreteStep3 { get; }

        IABaseStep<IVMDeleteA> NewDeleteAConcreteStep1 { get; }
        IABaseStep<IVMDeleteA> NewDeleteAConcreteStep2 { get; }

        #endregion

        #region FEATURE STEPS B

        IABaseStep<IVMCreateB> NewCreateBConcreteStep1 { get; }
        IABaseStep<IVMCreateB> NewCreateBConcreteStep2 { get; }
        IABaseStep<IVMCreateB> NewCreateBConcreteStep3 { get; }

        #endregion
    }
}