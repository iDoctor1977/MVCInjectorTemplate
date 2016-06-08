using Injector.Business.BusinessModel;
using Injector.Common.IEntity;
using Injector.Common.IModel;
using Injector.Common.IOperator;
using Injector.Common.ISupplier;

namespace Injector.Business.BusinessLayer
{
    public class OperatorB : ABaseOperator, IOperatorB
    {
        public OperatorB() { }
        public OperatorB(IDataSupplier dataSupplier) : base(dataSupplier) { }

        public IModelB ReadModel(int id)
        {
            IEntityB entity = repositoryB.ReadEntity(id);
            return ConvertEntityBToModelB(entity);
        }

        public IModelB ReadModelByUsername(string username)
        {
            IEntityB entityB = repositoryB.ReadEntityByUsername(username);
            return ConvertEntityBToModelB(entityB);
        }

        public void CreateModel(IModelB modelB)
        {
            IEntityB entity = repositoryB.GetConcreteEntityB();
            repositoryB.CreateEntity(entity);
        }

        public void UpdateModel(IModelB modelB)
        {
            IEntityB entity = repositoryB.GetConcreteEntityB();
            repositoryB.UpdateEntity(entity);
        }

        public void DeleteModel(IModelB modelB)
        {
            IEntityB entity = repositoryB.GetConcreteEntityB();
            repositoryB.DeleteEntity(entity);
        }

        public string ToStringOperator()
        {
            return "Welcome in BusinessOperator!";
        }

        public IModelB ConvertEntityBToModelB(IEntityB entityB)
        {
            return new ModelB
            {
                Id = entityB.Id,
                Username = entityB.Username,
                Email = entityB.Email,
            };
        }

        public IEntityB ConvertModelBToEntityB(IModelB modelB)
        {
            IEntityB entityB = repositoryB.GetConcreteEntityB();
            entityB.Id = modelB.Id;
            entityB.Username = modelB.Username;
            entityB.Email = modelB.Email;
            return entityB;
        }
    }
}