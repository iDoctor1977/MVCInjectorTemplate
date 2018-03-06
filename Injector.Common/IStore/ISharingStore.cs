using Injector.Common.IEntity;

namespace Injector.Common.IStore
{
    public interface ISharingStore
    {
        IEntityA NewModelA { get; }
        IEntityB NewModelB { get; }
    }
}