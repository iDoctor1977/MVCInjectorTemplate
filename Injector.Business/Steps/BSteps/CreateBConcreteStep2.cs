using Injector.Business.Steps.ASteps;
using Injector.Common.DTOModel;
using Injector.Common.IBind;

namespace Injector.Business.Steps.BSteps
{
    public class CreateBConcreteStep2 : ABaseStepB
    {
        #region CONSTRUCTOR

        public CreateBConcreteStep2() { }

        public CreateBConcreteStep2(ICoreBind coreBind) : base(coreBind) { }

        #endregion

        public override ModelB Execute(ModelB modelB)
        {
            // Read

            // Do

            // Write

            if (NextStep != null)
            {
                NextStep.Execute(modelB);
            }

            return modelB;
        }
    }
}