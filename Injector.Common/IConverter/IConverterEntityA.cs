using Injector.Common.DTOModel;
using Injector.Common.IEntity;

namespace Injector.Common.IConverter
{
    public interface IConverterEntityA
    {
        ModelB ConvertEntityToModel(IEntityB entityB);
        IEntityB ConvertModelToEntity(ModelB modelB);
    }
}