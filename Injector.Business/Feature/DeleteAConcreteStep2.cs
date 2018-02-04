using System;
using Injector.Common.DTOModel;
using Injector.Common.IStore;

namespace Injector.Business.Feature
{
    public class DeleteAConcreteStep2 : ABaseStep
    {
        #region CONSTRUCTOR

        public DeleteAConcreteStep2() { }

        public DeleteAConcreteStep2(ICoreStore coreStore) : base(coreStore) { }

        #endregion

        public override ModelA HandleStep(ModelA modelA)
        {
            // Do something...

            Do(modelA);

            // Do something...

            if (Successor != null)
            {
                modelA = Successor.HandleStep(modelA);
            }

            return modelA;
        }

        protected override ModelA Read(ModelA modelA)
        {
            throw new NotImplementedException();
        }

        protected override void Do(ModelA modelA)
        {
            // do something on repository data layer
            ABaseStore.StoreDataSupplier.GetRepositoryA.DeleteEntity(modelA);
        }

        protected override void Write(ModelA modelA)
        {
            throw new NotImplementedException();
        }
    }
}