using Injector.Common.DTOModel;
using Injector.Common.IBind;

namespace Injector.Business.Steps.ASteps
{
    public class DeleteAConcreteStep1 : ABaseStepA
    {
        #region CONSTRUCTOR

        public DeleteAConcreteStep1() { }

        public DeleteAConcreteStep1(ICoreBind coreBind) : base(coreBind) { }

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