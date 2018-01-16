using Injector.Common.IModel;

namespace Injector.Common.IStore
{
    public interface ISharingStore
    {
        IModelA NewModelA { get; }
        IModelB NewModelB { get; }
    }
}