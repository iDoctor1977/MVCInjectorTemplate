using Injector.Common.DTOModel;
using Injector.Common.IBond;

namespace Injector.Business.Step
{
    public class DeleteAConcreteStep2 : ABaseStep
    {
        #region CONSTRUCTOR

        public DeleteAConcreteStep2() { }

        public DeleteAConcreteStep2(ICoreBond coreBond) : base(coreBond) { }

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