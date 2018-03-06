using Injector.Business.Steps.ASteps;
using Injector.Business.Steps.BSteps;
using Injector.Common.DTOModel;
using Injector.Common.IABase;
using Injector.Common.IBind;
using Injector.Common.IStore;

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

        public IABaseStep<ModelA> NewCreateAConcreteStep1 => new CreateAConcreteStep1(StoreBind);
        public IABaseStep<ModelA> NewCreateAConcreteStep2 => new CreateAConcreteStep2(StoreBind);
        public IABaseStep<ModelA> NewCreateAConcreteStep3 => new CreateAConcreteStep3(StoreBind);

        public IABaseStep<ModelA> NewDeleteAConcreteStep1 => new DeleteAConcreteStep1(StoreBind);
        public IABaseStep<ModelA> NewDeleteAConcreteStep2 => new DeleteAConcreteStep2(StoreBind);

        #endregion

        #region STEPS B

        public IABaseStep<ModelB> NewCreateBConcreteStep1 => new CreateBConcreteStep1(StoreBind);
        public IABaseStep<ModelB> NewCreateBConcreteStep2 => new CreateBConcreteStep2(StoreBind);
        public IABaseStep<ModelB> NewCreateBConcreteStep3 => new CreateBConcreteStep3(StoreBind);

        #endregion
    }
}