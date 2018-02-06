﻿using Injector.Common.DTOModel;
using Injector.Common.IBind;

namespace Injector.Business.Step
{
    public class CreateAConcreteStep3 : ABaseStep
    {
        #region CONSTRUCTOR

        public CreateAConcreteStep3() { }

        public CreateAConcreteStep3(ICoreBind coreBind) : base(coreBind) { }

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