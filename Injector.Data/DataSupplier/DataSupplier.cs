using Injector.Common.IRepository;
using Injector.Common.ISupplier;
using Injector.Data.DataLayer;

namespace Injector.Data.DataSupplier
{
    public class DataSupplier : IDataSupplier
    {
        private IDataRepository dataRepository;

        public IDataRepository GenerateDataRepository()
        {
            return dataRepository ?? (dataRepository = new DataRepository());
        }
    }
}