using Injector.Common.DTOModel;
using Injector.Common.IConverter;
using Injector.Common.IEntity;
using Injector.Common.ISupplier;
using Injector.Data.ADOModel;

namespace Injector.Data.Converter
{
    public class ConverterA : AConvBase, IConverterA
    {
        #region CONSTRUCTOR

        public ConverterA()
        {
        }

        public ConverterA(ISharingSupplier sharingSupplier) : base(sharingSupplier)
        {
        }

        #endregion

        public ModelA ConvertEntityToModel(IEntityA entityA)
        {
            ModelA modelA = AConvBaseDataStore.DStoreCommonSupplier.GetModelA() as ModelA;
            modelA.Id = entityA.Id;
            modelA.Name = entityA.Name;
            modelA.Surname = entityA.Surname;

            return modelA;
        }

        public IEntityA ConvertModelToEntity(ModelA modelA)
        {
            EntityA entityA = AConvBaseDataStore.NewEntityA as EntityA;

            return new EntityA
            {
                Id = modelA.Id,
                Name = modelA.Name,
                Surname = modelA.Surname
            };
        }
    }
}
