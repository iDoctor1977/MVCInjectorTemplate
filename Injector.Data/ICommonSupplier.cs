using Injector.Common.IModel;
using Injector.Common.IStore;

namespace Injector.Data
{
    public interface ICommonSupplier
    {
        ICommonStore CommonStore { get; set; }

        IModelA GetModelA();
        IModelA GetModelB();
    }
}