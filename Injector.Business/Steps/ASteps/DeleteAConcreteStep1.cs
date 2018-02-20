using Injector.Common.IBind;
using Injector.Common.IVModel;

namespace Injector.Business.Steps.ASteps
{
    public class DeleteAConcreteStep1 : ABaseStepA<IVMDeleteA>
    {
        #region CONSTRUCTOR

        public DeleteAConcreteStep1() { }

        public DeleteAConcreteStep1(ICoreBind coreBind) : base(coreBind) { }

        #endregion

        public override IVMDeleteA Execute(IVMDeleteA viewModelA)
        {
            // Read

            // Do

            // Write

            if (NextStep != null)
            {
                viewModelA = NextStep.Execute(viewModelA);
            }

            return viewModelA;
        }
    }
}