using Injector.Common.IModel;
using Injector.Common.IStore;

namespace Injector.Common.ISupplier
{
    public interface ICommonSupplier
    {
        ICommonStore CSCommonStore { get; set; }

        IModelA GetModelA();
        IModelB GetModelB();
    }
}