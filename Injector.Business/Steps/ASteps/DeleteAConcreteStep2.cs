using Injector.Common.DTOModel;
using Injector.Common.IBind;

namespace Injector.Business.Steps.ASteps
{
    public class DeleteAConcreteStep2 : ABaseStepA
    {
        #region CONSTRUCTOR

        public DeleteAConcreteStep2() { }

        public DeleteAConcreteStep2(ICoreBind coreBind) : base(coreBind) { }

        #endregion

        public override ModelA Execute(ModelA modelA)
        {
            // Read

            // Do

            // Write

            if (NextStep != null)
            {
                modelA = NextStep.Execute(modelA);
            }

            return modelA;
        }
    }
}