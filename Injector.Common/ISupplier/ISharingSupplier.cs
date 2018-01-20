using Injector.Common.IModel;

namespace Injector.Common.ISupplier
{
    public interface ISharingSupplier
    {
        IModelA GetModelA();
        IModelB GetModelB();
    }
}