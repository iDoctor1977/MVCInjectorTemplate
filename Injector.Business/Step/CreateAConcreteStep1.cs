using Injector.Common.DTOModel;
using Injector.Common.IBond;

namespace Injector.Business.Step
{
    public class CreateAConcreteStep1 : ABaseStep
    {
        #region CONSTRUCTOR

        public CreateAConcreteStep1() { }

        public CreateAConcreteStep1(ICoreBond coreBond) : base(coreBond) { }

        #endregion

        public override ModelA HandleStep(ModelA modelA)
        {
            // Read
            modelA = ABaseBond.BondDataSupplier.GetRepositoryA.ReadEntityById(modelA.Id);

            // Do
            modelA.Name = "pippo";

            // Write
            ABaseBond.BondDataSupplier.GetRepositoryA.CreateEntity(modelA);

            if (Successor != null)
            {
                modelA = Successor.HandleStep(modelA);
            }

            return modelA;
        }
    }
}