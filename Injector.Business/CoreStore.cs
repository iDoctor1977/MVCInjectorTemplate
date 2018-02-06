using Injector.Business.Step;
using Injector.Common.IABase;
using Injector.Common.IBind;
using Injector.Common.IStore;

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

        public IABaseStep NewCreateAConcreteStep1 => new CreateAConcreteStep1(ABaseCoreBind);
        public IABaseStep NewCreateAConcreteStep2 => new CreateAConcreteStep2(ABaseCoreBind);
        public IABaseStep NewCreateAConcreteStep3 => new CreateAConcreteStep3(ABaseCoreBind);

        public IABaseStep NewDeleteAConcreteStep1 => new DeleteAConcreteStep1(ABaseCoreBind);
        public IABaseStep NewDeleteAConcreteStep2 => new DeleteAConcreteStep2(ABaseCoreBind);
    }
}