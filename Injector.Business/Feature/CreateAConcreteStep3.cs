using Injector.Common.DTOModel;
using Injector.Common.IStore;

namespace Injector.Business.Feature
{
    public class CreateAConcreteStep3 : ABaseStep
    {
        #region CONSTRUCTOR

        public CreateAConcreteStep3() { }

        public CreateAConcreteStep3(ICoreStore coreStore) : base(coreStore) { }

        #endregion

        public override ModelA HandleStep(ModelA modelA)
        {
            modelA = Read(modelA);

            // Do something...

            Do(modelA);

            // Do something...

            Write(modelA);

            if (Successor != null)
            {
                Successor.HandleStep(modelA);
            }

            return modelA;
        }

        protected override ModelA Read(ModelA modelA)
        {
            // Read from repository data layer
            return modelA;
        }

        protected override void Do(ModelA modelA)
        {
            // do something on repository data layer
        }

        protected override void Write(ModelA modelA)
        {
            // write on repository data layer
        }
    }
}