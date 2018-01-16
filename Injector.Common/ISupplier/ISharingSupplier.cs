using Injector.Common.IModel;
using Injector.Common.IStore;

namespace Injector.Common.ISupplier
{
    public interface ISharingSupplier
    {
        ISharingStore SStoreCommonStore { get; set; }

        IModelA GetModelA();
        IModelB GetModelB();
    }
}