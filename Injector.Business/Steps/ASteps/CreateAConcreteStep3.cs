using Injector.Common.DTOModel;
using Injector.Common.IBind;

namespace Injector.Business.Steps.ASteps
{
    public class CreateAConcreteStep3 : ABaseStepA
    {
        #region CONSTRUCTOR

        public CreateAConcreteStep3() { }

        public CreateAConcreteStep3(ICoreBind coreBind) : base(coreBind) { }

        #endregion

        public override ModelA Execute(ModelA modelA)
        {
            // Read

            // Do

            // Write

            if (NextStep != null)
            {
                NextStep.Execute(modelA);
            }

            return modelA;
        }
    }
}