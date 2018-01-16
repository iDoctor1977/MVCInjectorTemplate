using Injector.Common.DTOModel;
using Injector.Common.IEntity;
using Injector.Common.IModel;

namespace Injector.Common.IConverter
{
    public interface IConverterA
    {
        ModelA ConvertEntityToModel(IEntityA entityA);
        IEntityA ConvertModelToEntity(ModelA modelA);
    }
}