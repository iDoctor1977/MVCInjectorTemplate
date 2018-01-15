using Injector.Common.DTOModel;
using Injector.Common.IEntity;

namespace Injector.Common.IConverter
{
    public interface IConverterEntityB
    {
        ModelA ConvertEntityToModel(IEntityA entityA);
        IEntityA ConvertModelToEntity(ModelA modelA);

    }
}