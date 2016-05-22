using Injector.Business.BusinessSupplier;
using Injector.Common.ISupplier;

namespace Injector.Frontend
{
    public class FrontendInjector
    {
        public static IBusinessSupplier GetBusinessSupplier(IBusinessSupplier businessSupplier)
        {
            if (businessSupplier == null)
            {
                return new BusinessSupplier();
            }
            return businessSupplier;
        }
    }
}