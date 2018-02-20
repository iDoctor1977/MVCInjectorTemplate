using Injector.Common.IBind;
using Injector.Common.IVModel;

namespace Injector.Business.Steps.ASteps
{
    public class DeleteAConcreteStep2 : ABaseStepA<IVMDeleteA>
    {
        #region CONSTRUCTOR

        public DeleteAConcreteStep2() { }

        public DeleteAConcreteStep2(ICoreBind coreBind) : base(coreBind) { }

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