using Injector.Business.BusinessLayer;
using Injector.Common.IOperator;
using Injector.Common.ISupplier;

namespace Injector.Business.BusinessSupplier
{
    public class BusinessSupplier : IBusinessSupplier
    {
        private IInjectorOperator injectorOperator;

        public IInjectorOperator GenerateBusinessOperator()
        {
            if (injectorOperator == null)
            {
                injectorOperator = new InjectorOperator();
            }
            return injectorOperator;
        }
    }
}