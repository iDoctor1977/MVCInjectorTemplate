using Injector.Common.DTOModel;
using Injector.Common.IBind;

namespace Injector.Business.Step
{
    public class CreateAConcreteStep2 : ABaseStep
    {
        #region CONSTRUCTOR

        public CreateAConcreteStep2() { }

        public CreateAConcreteStep2(ICoreBind coreBind) : base(coreBind) { }

        #endregion

        public override ModelA HandleStep(ModelA modelA)
        {
            // Read

            // Do

            // Write

            if (Successor != null)
            {
                Successor.HandleStep(modelA);
            }

            return modelA;
        }
    }
}