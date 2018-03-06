using Injector.Common.IEntity;

namespace Injector.Common.ISupplier
{
    public interface ISharingSupplier
    {
        IEntityA GetModelA();
        IEntityB GetModelB();
    }
}