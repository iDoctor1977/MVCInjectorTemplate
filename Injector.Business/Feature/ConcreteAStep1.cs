using Injector.Common.DTOModel;
using Injector.Common.IFeature;

namespace Injector.Business.Feature
{
    public class ConcreteAStep1 : ABaseStep, IConcreteAStep1
    {
        public override ModelA HandleStep(ModelA modelA)
        {
            modelA = Read(modelA);

            // Do something...

            Do(modelA);

            // Do something...

            Write(modelA);

            if (Successor != null)
            {
                modelA = Successor.HandleStep(modelA);
            }

            return modelA;
        }

        protected override ModelA Read(ModelA modelA)
        {
            // Read from repository data layer
            return ABaseStore.StoreDataSupplier.GetRepositoryA.ReadEntityById(modelA.Id);
        }

        protected override void Do(ModelA modelA)
        {
            // do something on repository data layer
        }

        protected override void Write(ModelA modelA)
        {
            ABaseStore.StoreDataSupplier.GetRepositoryA.CreateEntity(modelA);
        }
    }
}