using Injector.Common.IEntity;
using Injector.Common.IModel;
using Injector.Common.IOperator;

namespace Injector.Business.BusinessLayer
{
    public class OperatorB : ABaseOperator, IOperatorB
    {
        public IModelB GetModel(int id)
        {
            IEntityB entity = repositoryB.GetEntity(id);
            return ConvertToModelB(entity);
        }

        public void AddModel(IModelB model)
        {
            IEntityB entity = repositoryB.ConvertToDataEntity(model);
            repositoryB.AddEntity(entity);
        }

        public void EditModel(IModelB model)
        {
            IEntityB entity = repositoryB.ConvertToDataEntity(model);
            repositoryB.EditEntity(entity);
        }

        public void DeleteModel(IModelB model)
        {
            IEntityB entity = repositoryB.ConvertToDataEntity(model);
            repositoryB.DeleteEntity(entity);
        }

        public string ToStringOperator()
        {
            return "Welcome in BusinessOperator!";
        }

        public IModelB ConvertToModelB(IEntityB entity)
        {
            return new ModelB()
            {
                Id = entity.Id,
                Username = entity.Username,
                Email = entity.Email
            };
        }
    }
}