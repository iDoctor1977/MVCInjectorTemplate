using Injector.Common.DTOModel;
using Injector.Common.IEntity;
using Injector.Common.IStore;

namespace Injector.Common.IABase
{
    public interface IABaseRepository
    {
        IDataStore ABaseStore { get; set; }

        ModelA ConvertAEntityToModel(IEntityA entityA);
        IEntityA ConvertAModelToEntity(ModelA modelA);


        ModelB ConvertBEntityToModel(IEntityB entityB);
        IEntityB ConvertBModelToEntity(ModelB modelB);
    }
}