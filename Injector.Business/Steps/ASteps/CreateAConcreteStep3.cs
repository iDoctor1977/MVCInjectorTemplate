using Injector.Common.IBind;
using Injector.Common.IVModel;

namespace Injector.Business.Steps.ASteps
{
    public class CreateAConcreteStep3 : ABaseStepA<IVMCreateA>
    {
        #region CONSTRUCTOR

        public CreateAConcreteStep3() { }

        public CreateAConcreteStep3(ICoreBind coreBind) : base(coreBind) { }

        #endregion

        public override IVMCreateA Execute(IVMCreateA viewModelA)
        {
            // Read

            // Do

            // Write

            if (NextStep != null)
            {
                NextStep.Execute(viewModelA);
            }

            return viewModelA;
        }
    }
}