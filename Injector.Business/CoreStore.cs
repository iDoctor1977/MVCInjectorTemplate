using Injector.Business.Step;
using Injector.Common.IABase;
using Injector.Common.IBond;
using Injector.Common.IStore;

namespace Injector.Business
{
    internal class CoreStore : ABaseCoreStore, ICoreStore
    {
        #region CONSTRUCTOR

        private CoreStore() { }

        private CoreStore(ICoreBond coreBond) : base(coreBond) { }

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

        public static ICoreStore Instance(ICoreBond coreBond)
        {
            if (CoreStoreIstance == null)
            {
                CoreStoreIstance = new CoreStore(coreBond);
            }

            return CoreStoreIstance;
        }

        #endregion

        public IABaseStep NewCreateAConcreteStep1 => new CreateAConcreteStep1(ABaseCoreBond);
        public IABaseStep NewCreateAConcreteStep2 => new CreateAConcreteStep2(ABaseCoreBond);
        public IABaseStep NewCreateAConcreteStep3 => new CreateAConcreteStep3(ABaseCoreBond);

        public IABaseStep NewDeleteAConcreteStep1 => new DeleteAConcreteStep1(ABaseCoreBond);
        public IABaseStep NewDeleteAConcreteStep2 => new DeleteAConcreteStep2(ABaseCoreBond);
    }
}