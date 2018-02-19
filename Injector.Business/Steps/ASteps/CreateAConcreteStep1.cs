using Injector.Common.DTOModel;
using Injector.Common.IBind;

namespace Injector.Business.Steps.ASteps
{
    public class CreateAConcreteStep1 : ABaseStepA
    {
        #region CONSTRUCTOR

        public CreateAConcreteStep1() { }

        public CreateAConcreteStep1(ICoreBind coreBind) : base(coreBind) { }

        #endregion

        public override ModelA Execute(ModelA modelA)
        {
            // Read
            modelA = ABaseBind.BindDataSupplier.GetRepositoryA.ReadEntityById(modelA.Id);

            // Do
            modelA.Name = "pippo";

            // Write
            ABaseBind.BindDataSupplier.GetRepositoryA.CreateEntity(modelA);

            if (NextStep != null)
            {
                modelA = NextStep.Execute(modelA);
            }

            return modelA;
        }
    }
}