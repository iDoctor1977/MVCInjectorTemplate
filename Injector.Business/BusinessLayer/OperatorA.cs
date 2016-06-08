using Injector.Business.BusinessModel;
using Injector.Common.IEntity;
using Injector.Common.IModel;
using Injector.Common.IOperator;
using Injector.Common.ISupplier;

namespace Injector.Business.BusinessLayer
{
    public class OperatorA : ABaseOperator, IOperatorA
    {
        public OperatorA() { }

        public OperatorA(IDataSupplier dataSupplier) : base(dataSupplier) { }

        public IModelA ReadModel(int id)
        {
            IEntityA entityA = repositoryA.ReadEntity(id);
            return ConvertEntityAToModelA(entityA);
        }

        public IModelA ReadModelByName(string name)
        {
            IEntityA entityA = repositoryA.ReadEntityByName(name);
            return ConvertEntityAToModelA(entityA);
        }

        public void CreateModel(IModelA modelA)
        {
            IEntityA entityA = ConvertModelAToEntityA(modelA);
            repositoryA.CreateEntity(entityA);
        }

        public void UpdateModel(IModelA modelA)
        {
            IEntityA entity = repositoryA.GetConcreteEntityA();
            repositoryA.UpdateEntity(entity);
        }

        public void DeleteModel(IModelA modelA)
        {
            IEntityA entity = repositoryA.GetConcreteEntityA();
            repositoryA.DeleteEntity(entity);
        }

        public string ToStringOperator()
        {
            return "Welcome in BusinessOperator!";
        }

        public IModelA ConvertEntityAToModelA(IEntityA entityA)
        {
            return new ModelA
            {
                Id = entityA.Id,
                Name = entityA.Name,
                Surname = entityA.Surname,
            };
        }

        public IEntityA ConvertModelAToEntityA(IModelA modelA)
        {
            IEntityA entityA = repositoryA.GetConcreteEntityA();
            entityA.Id = modelA.Id;
            entityA.Name = modelA.Name;
            entityA.Surname = modelA.Surname;
            return entityA;
        }
    }
}