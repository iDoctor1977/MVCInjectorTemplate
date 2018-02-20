using Injector.Business.Steps;
using Injector.Business.Steps.ASteps;
using Injector.Business.Steps.BSteps;
using Injector.Common.DTOModel;
using Injector.Common.IABase;
using Injector.Common.IBind;
using Injector.Common.IStore;
using Injector.Common.IVModel;

namespace Injector.Business
{
    internal class CoreStore : ABaseCoreStore, ICoreStore
    {
        #region CONSTRUCTOR

        private CoreStore() { }

        private CoreStore(ICoreBind coreBind) : base(coreBind) { }

        #endregion

        #region SINGLETON

        private static ICoreStore CoreStoreIstance { get; set; }

        public static ICoreStore Instance()
        {
            if (CoreStoreIstance == null)
            {
                CoreStoreIstance = new CoreStore();
            }

            return CoreStoreIstance;
        }

        public static ICoreStore Instance(ICoreBind coreBind)
        {
            if (CoreStoreIstance == null)
            {
                CoreStoreIstance = new CoreStore(coreBind);
            }

            return CoreStoreIstance;
        }

        #endregion

        #region STEPS A

        public IABaseStep<IVMCreateA> NewCreateAConcreteStep1 => new CreateAConcreteStep1(ABaseCoreBind);
        public IABaseStep<IVMCreateA> NewCreateAConcreteStep2 => new CreateAConcreteStep2(ABaseCoreBind);
        public IABaseStep<IVMCreateA> NewCreateAConcreteStep3 => new CreateAConcreteStep3(ABaseCoreBind);

        public IABaseStep<IVMDeleteA> NewDeleteAConcreteStep1 => new DeleteAConcreteStep1(ABaseCoreBind);
        public IABaseStep<IVMDeleteA> NewDeleteAConcreteStep2 => new DeleteAConcreteStep2(ABaseCoreBind);

        #endregion

        #region STEPS B

        public IABaseStep<IVMCreateB> NewCreateBConcreteStep1 => new CreateBConcreteStep1(ABaseCoreBind);
        public IABaseStep<IVMCreateB> NewCreateBConcreteStep2 => new CreateBConcreteStep2(ABaseCoreBind);
        public IABaseStep<IVMCreateB> NewCreateBConcreteStep3 => new CreateBConcreteStep3(ABaseCoreBind);

        #endregion
    }
}