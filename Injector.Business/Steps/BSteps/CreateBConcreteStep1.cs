using Injector.Common.DTOModel;
using Injector.Common.IBind;

namespace Injector.Business.Steps.BSteps
{
    public class CreateBConcreteStep1 : ABaseStepB
    {
        #region CONSTRUCTOR

        public CreateBConcreteStep1() { }

        public CreateBConcreteStep1(ICoreBind coreBind) : base(coreBind) { }

        #endregion

        public override ModelB Execute(ModelB modelB)
        {
            // Read
            modelB = ABaseBind.BindDataSupplier.GetRepositoryB.ReadEntityById(modelB.Id);

            // Do
            modelB.Email = "pippo@gmail.com";

            // Write
            ABaseBind.BindDataSupplier.GetRepositoryB.CreateEntity(modelB);

            if (NextStep != null)
            {
                modelB = NextStep.Execute(modelB);
            }

            return modelB;
        }
    }
}