using Injector.Business.Steps.ASteps;
using Injector.Common.IBind;
using Injector.Common.IVModel;

namespace Injector.Business.Steps.BSteps
{
    public class CreateBConcreteStep2 : ABaseStepB<IVMCreateB>
    {
        #region CONSTRUCTOR

        public CreateBConcreteStep2() { }

        public CreateBConcreteStep2(ICoreBind coreBind) : base(coreBind) { }

        #endregion

        public override IVMCreateB Execute(IVMCreateB viewModelB)
        {
            // Read

            // Do

            // Write

            if (NextStep != null)
            {
                NextStep.Execute(viewModelB);
            }

            return viewModelB;
        }
    }
}