using Injector.Common.IConverter;
using Injector.Common.IEntity;
using Injector.Common.ISupplier;
using Injector.Common.IDbContext;

namespace Injector.Common.IStore
{
    public interface IDataStore
    {
        string DStoreConnectionStringName { get; set; }
        IProjectDbContext DStoreProjectDbContext { get; set; }

        // DTOModels
        ISharingSupplier DStoreCommonSupplier { get; set; }

        // Entities
        IEntityA NewEntityA { get; set; }
        IEntityB NewEntityB { get; set; }

        // Converter Model - Entity - Model
        IConverterA NewConverterA { get; set; }
        IConverterB NewConverterB { get; set; }
    }
}