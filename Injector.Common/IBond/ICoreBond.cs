using Injector.Common.ISupplier;

namespace Injector.Common.IBond
{
    public interface ICoreBond
    {
        IDataSupplier BondDataSupplier { get; set; }
        ISharingSupplier BondSharingSupplier { get; set; }
    }
}