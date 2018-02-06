using Injector.Common.ISupplier;

namespace Injector.Common.IBind
{
    public interface ICoreBind
    {
        IDataSupplier BindDataSupplier { get; set; }
        ISharingSupplier BindSharingSupplier { get; set; }
    }
}