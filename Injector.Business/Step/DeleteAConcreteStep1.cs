using Injector.Common.DTOModel;
using Injector.Common.IBind;

namespace Injector.Business.Step
{
    public class DeleteAConcreteStep1 : ABaseStep
    {
        #region CONSTRUCTOR

        public DeleteAConcreteStep1() { }

        public DeleteAConcreteStep1(ICoreBind coreBind) : base(coreBind) { }

        #endregion

        public override ModelA HandleStep(ModelA modelA)
        {
            // Read

            // Do

            // Write

            if (Successor != null)
            {
                modelA = Successor.HandleStep(modelA);
            }

            return modelA;
        }
    }
}