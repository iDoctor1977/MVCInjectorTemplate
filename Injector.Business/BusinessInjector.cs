using Injector.Common.ISupplier;
using Injector.Data.DataSupplier;

namespace Injector.Business
{
    public class BusinessInjector
    {
        public static IDataSupplier GetDataSupplier(IDataSupplier dataSupplier)
        {
            if (ReferenceEquals(dataSupplier, null))
            {
                return new DataSupplier();
            }
            return dataSupplier;
        }
    }
}