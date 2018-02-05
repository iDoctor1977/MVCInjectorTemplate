using Injector.Common.DTOModel;
using Injector.Common.IBond;

namespace Injector.Business.Step
{
    public class DeleteAConcreteStep1 : ABaseStep
    {
        #region CONSTRUCTOR

        public DeleteAConcreteStep1() { }

        public DeleteAConcreteStep1(ICoreBond coreBond) : base(coreBond) { }

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