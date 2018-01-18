using Injector.Common.IEntity;
using Injector.Common.ISupplier;
using Injector.Common.IDbContext;

namespace Injector.Common.IStore
{
    public interface IDataStore
    {
        string StoreConnectionStringName { get; set; }
        IProjectDbContext StoreProjectDbContext { get; set; }
        ISharingSupplier StoreCommonSupplier { get; set; }

        // Entities
        IEntityA NewEntityA { get; set; }
        IEntityB NewEntityB { get; set; }
    }
}