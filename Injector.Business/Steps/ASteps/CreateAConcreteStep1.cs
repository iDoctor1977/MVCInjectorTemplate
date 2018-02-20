using Injector.Common.IBind;
using Injector.Common.IVModel;

namespace Injector.Business.Steps.ASteps
{
    public class CreateAConcreteStep1 : ABaseStepA<IVMCreateA>
    {
        #region CONSTRUCTOR

        public CreateAConcreteStep1() { }

        public CreateAConcreteStep1(ICoreBind coreBind) : base(coreBind) { }

        #endregion

        public override IVMCreateA Execute(IVMCreateA viewModelA)
        {
            // Read
            viewModelA.DTOModelA = ABaseBind.BindDataSupplier.GetRepositoryA.ReadEntityById(viewModelA.DTOModelA.Id);

            // Do
            viewModelA.DTOModelA.Name = "pippo";

            // Write
            ABaseBind.BindDataSupplier.GetRepositoryA.CreateEntity(viewModelA.DTOModelA);

            if (NextStep != null)
            {
                viewModelA = NextStep.Execute(viewModelA);
            }

            return viewModelA;
        }
    }
}