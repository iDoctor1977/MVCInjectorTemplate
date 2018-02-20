using Injector.Common.IBind;
using Injector.Common.IVModel;

namespace Injector.Business.Steps.BSteps
{
    public class CreateBConcreteStep1 : ABaseStepB<IVMCreateB>
    {
        #region CONSTRUCTOR

        public CreateBConcreteStep1() { }

        public CreateBConcreteStep1(ICoreBind coreBind) : base(coreBind) { }

        #endregion

        public override IVMCreateB Execute(IVMCreateB viewModelB)
        {
            // Read
            viewModelB.DTOModelB = ABaseBind.BindDataSupplier.GetRepositoryB.ReadEntityById(viewModelB.DTOModelB.Id);

            // Do
            viewModelB.DTOModelB.Email = "pippo@gmail.com";

            // Write
            ABaseBind.BindDataSupplier.GetRepositoryB.CreateEntity(viewModelB.DTOModelB);

            if (NextStep != null)
            {
                viewModelB = NextStep.Execute(viewModelB);
            }

            return viewModelB;
        }
    }
}