using Injector.Common.DTOModel;
using Injector.Common.IBind;

namespace Injector.Business.Step
{
    public class CreateAConcreteStep1 : ABaseStep
    {
        #region CONSTRUCTOR

        public CreateAConcreteStep1() { }

        public CreateAConcreteStep1(ICoreBind coreBind) : base(coreBind) { }

        #endregion

        public override ModelA HandleStep(ModelA modelA)
        {
            // Read
            modelA = ABaseBond.BindDataSupplier.GetRepositoryA.ReadEntityById(modelA.Id);

            // Do
            modelA.Name = "pippo";

            // Write
            ABaseBond.BindDataSupplier.GetRepositoryA.CreateEntity(modelA);

            if (Successor != null)
            {
                modelA = Successor.HandleStep(modelA);
            }

            return modelA;
        }
    }
}