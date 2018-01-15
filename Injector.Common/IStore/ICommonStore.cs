using Injector.Common.IModel;

namespace Injector.Common.IStore
{
    public interface ICommonStore
    {
        IModelA NewModelA { get; }
        IModelB NewModelB { get; }
    }
}