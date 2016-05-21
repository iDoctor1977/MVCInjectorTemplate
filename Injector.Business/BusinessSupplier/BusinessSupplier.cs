using Injector.Business.BusinessLayer;
using Injector.Common.IOperator;
using Injector.Common.ISupplier;

namespace Injector.Business.BusinessSupplier
{
    public class BusinessSupplier : IBusinessSupplier
    {
        private IBusinessOperator businessOperator;

        public IBusinessOperator GenerateBusinessOperator()
        {
            return businessOperator ?? (businessOperator = new BusinessOperator());
        }
    }
}