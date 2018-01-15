using Injector.Common.IConverter;
using Injector.Common.IEntity;
using Injector.Common.ISupplier;
using Injector.Common.IDbContext;

namespace Injector.Common.IStore
{
    public interface IDataStore
    {
        string ConnectionStringName { get; set; }

        IProjectDbContext ProjectDbContext { get; set; }

        // DTOModels
        ICommonSupplier CommonSupplier { get; set; }

        // Entities
        IEntityA GetEntityA { get; set; }
        IEntityB GetEntityB { get; set; }

        // Converter Model - Entity - Model
        IConverterEntityA NewConverterEntityA { get; set; }

        IConverterEntityB NewConverterEntityB { get; set; }
    }
}