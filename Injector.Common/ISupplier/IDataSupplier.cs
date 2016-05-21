using Injector.Common.IRepository;

namespace Injector.Common.ISupplier
{
    public interface IDataSupplier
    {
        IDataRepository GenerateDataRepository();
    }
}