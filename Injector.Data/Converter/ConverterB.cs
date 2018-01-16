using System;
using Injector.Common.DTOModel;
using Injector.Common.IConverter;
using Injector.Common.IEntity;
using Injector.Common.IModel;

namespace Injector.Data.Converter
{
    public class ConverterB : IConverterB
    {
        public ModelB ConvertEntityToModel(IEntityB entityB)
        {
            return new ModelB
            {
                Id = entityB.Id,
                Username = entityB.Username,
                Email = entityB.Email
            };
        }

        public IEntityB ConvertModelToEntity(ModelB modelB)
        {
            return new ModelB
            {
                Id = modelB.Id,
                Username = modelB.Username,
                Email = modelB.Email
            };
        }
    }
}
