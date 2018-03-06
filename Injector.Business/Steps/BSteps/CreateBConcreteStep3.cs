﻿using Injector.Common.DTOModel;
using Injector.Common.IBind;

namespace Injector.Business.Steps.BSteps
{
    public class CreateBConcreteStep3 : ABaseStepB
    {
        #region CONSTRUCTOR

        public CreateBConcreteStep3() { }

        public CreateBConcreteStep3(ICoreBind coreBind) : base(coreBind) { }

        #endregion

        public override ModelB Execute(ModelB modelB)
        {
            // Read

            // Do

            // Write

            if (NextStep != null)
            {
                NextStep.Execute(modelB);
            }

            return modelB;
        }
    }
}