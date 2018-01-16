using Injector.Common.DTOModel;
using Injector.Common.IEntity;
using Injector.Common.IModel;

namespace Injector.Common.IConverter
{
    public interface IConverterB
    {
        ModelB ConvertEntityToModel(IEntityB entityB);
        IEntityB ConvertModelToEntity(ModelB modelB);

    }
}