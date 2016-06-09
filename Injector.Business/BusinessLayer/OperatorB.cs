using Injector.Business.BusinessModel;
using Injector.Common.IEntity;
using Injector.Common.IModel;
using Injector.Common.IOperator;

namespace Injector.Business.BusinessLayer
{
    public class OperatorB : ABaseOperator, IOperatorB
    {
        public OperatorB() { }

        public OperatorB(IBusinessStore businessStore) : base(businessStore) { }

        public IModelB ReadModel(int id)
        {
            IEntityB entity = GetIstanceOfRepositoryB.ReadEntityById(id);
            return ConvertEntityBToModelB(entity);
        }

        public IModelB ReadModelByUsername(string username)
        {
            IEntityB entityB = GetIstanceOfRepositoryB.ReadEntityByUsername(username);
            return ConvertEntityBToModelB(entityB);
        }

        public void CreateModel(IModelB modelB)
        {
            IEntityB entity = GetIstanceOfRepositoryB.GetConcreteEntityB();
            GetIstanceOfRepositoryB.CreateEntity(entity);
        }

        public void UpdateModel(IModelB modelB)
        {
            IEntityB entity = GetIstanceOfRepositoryB.GetConcreteEntityB();
            GetIstanceOfRepositoryB.UpdateEntity(entity);
        }

        public void DeleteModel(IModelB modelB)
        {
            IEntityB entity = GetIstanceOfRepositoryB.GetConcreteEntityB();
            GetIstanceOfRepositoryB.DeleteEntity(entity);
        }

        public string ToStringOperator()
        {
            return "Welcome in BusinessOperatorB!";
        }

        public IModelB ConvertEntityBToModelB(IEntityB entityB)
        {
            ModelB modelB = GetConcreteModelB;
            modelB.Id = entityB.Id;
            modelB.Username = entityB.Username;
            modelB.Email = entityB.Email;
            return modelB;
        }

        public IEntityB ConvertModelBToEntityB(IModelB modelB)
        {
            IEntityB entityB = GetIstanceOfRepositoryB.GetConcreteEntityB();
            entityB.Id = modelB.Id;
            entityB.Username = modelB.Username;
            entityB.Email = modelB.Email;
            return entityB;
        }
    }
}