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

        public override IVMCreateB Execute(IVMCreateB vmCreateB)
        {
            // Read
            vmCreateB.DTOModelB = ABaseBind.BindDataSupplier.GetRepositoryB.ReadEntityById(vmCreateB.DTOModelB.Id);

            // Do
            vmCreateB.DTOModelB.Email = "pippo@gmail.com";

            // Write
            ABaseBind.BindDataSupplier.GetRepositoryB.CreateEntity(vmCreateB.DTOModelB);

            if (NextStep != null)
            {
                vmCreateB = NextStep.Execute(vmCreateB);
            }

            return vmCreateB;
        }
    }
}