using Injector.Common.IEntity;
using Injector.Common.IModel;
using Injector.Common.IOperator;

namespace Injector.Business.BusinessLayer
{
    public class OperatorA : ABaseOperator, IOperatorA
    {
        public IModelA GetModel(int id)
        {
            IEntityA entity = repositoryA.GetEntity(id);
            return ConvertToModelA(entity);
        }

        public void AddModel(IModelA model)
        {
            IEntityA entity = repositoryA.ConvertToDataEntity(model);
            repositoryA.AddEntity(entity);
        }

        public void EditModel(IModelA model)
        {
            IEntityA entity = repositoryA.ConvertToDataEntity(model);
            repositoryA.EditEntity(entity);
        }

        public void DeleteModel(IModelA model)
        {
            IEntityA entity = repositoryA.ConvertToDataEntity(model);
            repositoryA.DeleteEntity(entity);
        }

        public string ToStringOperator()
        {
            return "Welcome in BusinessOperator!";
        }

        public IModelA ConvertToModelA(IEntityA entity)
        {
            return new ModelA
            {
                Id = entity.Id,
                Name = entity.Name,
                Surname = entity.Surname
            };
        }
    }
}