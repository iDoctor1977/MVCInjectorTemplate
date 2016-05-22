using Injector.Common.IEntity;
using Injector.Common.IModel;
using Injector.Common.IOperator;

namespace Injector.Business.BusinessLayer
{
    public class BusinessOperator : ABaseOperator, IBusinessOperator
    {
        public IDataModel GetModel(int id)
        {
            IDataEntity entity = dataRepository.GetEntity(id);
            return ConvertToDataModel(entity);
        }

        public void AddModel(IDataModel model)
        {
            IDataEntity entity = dataRepository.ConvertToDataEntity(model);
            dataRepository.AddEntity(entity);
        }

        public void EditModel(IDataModel model)
        {
            IDataEntity entity = dataRepository.ConvertToDataEntity(model);
            dataRepository.EditEntity(entity);
        }

        public void DeleteModel(IDataModel model)
        {
            IDataEntity entity = dataRepository.ConvertToDataEntity(model);
            dataRepository.DeleteEntity(entity);
        }

        public string ToStringOperator()
        {
            return "Welcome in BusinessOperator!";
        }

        public IDataModel ConvertToDataModel(IDataEntity entity)
        {
            return new DataModel
            {
                Id = entity.Id,
                Name = entity.Name,
                Surname = entity.Surname
            };
        }
    }
}