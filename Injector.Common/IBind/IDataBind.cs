using Injector.Common.ISupplier;

namespace Injector.Common.IBind
{
    public interface IDataBind
    {
        ISharingSupplier BindSharingSupplier { get; set; }
    }
}