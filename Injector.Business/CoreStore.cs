using Injector.Business.Steps.ASteps;
using Injector.Business.Steps.BSteps;
using Injector.Common.IABase;
using Injector.Common.IBind;
using Injector.Common.IStore;
using Injector.Common.IVModel;

namespace Injector.Business
{
    internal class CoreStore : ICoreStore
    {
        private ICoreBind _coreBind;

        #region CONSTRUCTOR

        private CoreStore() { }

        private CoreStore(ICoreBind coreBind)
        {
            StoreBind = coreBind;
        }

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

        public ICoreBind StoreBind
        {
            get { return _coreBind ?? (_coreBind = CoreBind.Instance()); }
            set { _coreBind = value; }
        }

        #region STEPS A

        public IABaseStep<IVMCreateA> NewCreateAConcreteStep1 => new CreateAConcreteStep1(StoreBind);
        public IABaseStep<IVMCreateA> NewCreateAConcreteStep2 => new CreateAConcreteStep2(StoreBind);
        public IABaseStep<IVMCreateA> NewCreateAConcreteStep3 => new CreateAConcreteStep3(StoreBind);

        public IABaseStep<IVMDeleteA> NewDeleteAConcreteStep1 => new DeleteAConcreteStep1(StoreBind);
        public IABaseStep<IVMDeleteA> NewDeleteAConcreteStep2 => new DeleteAConcreteStep2(StoreBind);

        #endregion

        #region STEPS B

        public IABaseStep<IVMCreateB> NewCreateBConcreteStep1 => new CreateBConcreteStep1(StoreBind);
        public IABaseStep<IVMCreateB> NewCreateBConcreteStep2 => new CreateBConcreteStep2(StoreBind);
        public IABaseStep<IVMCreateB> NewCreateBConcreteStep3 => new CreateBConcreteStep3(StoreBind);

        #endregion
    }
}