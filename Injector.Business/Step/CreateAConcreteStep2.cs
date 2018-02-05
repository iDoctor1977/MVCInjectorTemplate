using Injector.Common.DTOModel;
using Injector.Common.IBond;

namespace Injector.Business.Step
{
    public class CreateAConcreteStep2 : ABaseStep
    {
        #region CONSTRUCTOR

        public CreateAConcreteStep2() { }

        public CreateAConcreteStep2(ICoreBond coreBond) : base(coreBond) { }

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