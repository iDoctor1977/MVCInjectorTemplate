using Injector.Common.DTOModel;
using Injector.Common.IEntity;
using Injector.Common.ILogic;
using Injector.Common.IModel;

namespace Injector.Business.Layer
{
    public class LogicalA : ALBase, IOperatorA
    {
        public LogicalA() { }

        public LogicalA(IBusinessStore businessStore) : base(businessStore) { }

        public IModelA ReadModel(int id)
        {
            IEntityA entityA = GetIstanceOfRepositoryA.ReadEntityById(id);
            return ConvertEntityAToModelA(entityA);
        }

        public IModelA ReadModelByName(string name)
        {
            IEntityA entityA = GetIstanceOfRepositoryA.ReadEntityByName(name);
            return ConvertEntityAToModelA(entityA);
        }

        public void CreateModel(IModelA modelA)
        {
            IEntityA entityA = ConvertModelAToEntityA(modelA);
            GetIstanceOfRepositoryA.CreateEntity(entityA);
        }

        public void UpdateModel(IModelA modelA)
        {
            IEntityA entity = GetIstanceOfRepositoryA.GetConcreteEntityA();
            GetIstanceOfRepositoryA.UpdateEntity(entity);
        }

        public void DeleteModel(IModelA modelA)
        {
            IEntityA entity = GetIstanceOfRepositoryA.GetConcreteEntityA();
            GetIstanceOfRepositoryA.DeleteEntity(entity);
        }

        public string ToStringOperator()
        {
            return "Welcome in BusinessOperatorA!";
        }

        public IModelA ConvertEntityAToModelA(IEntityA entityA)
        {
            ModelA modelA = GetConcreteModelA;
            modelA.Id = entityA.Id;
            modelA.Name = entityA.Name;
            modelA.Surname = entityA.Surname;
            return modelA;
        }

        public IEntityA ConvertModelAToEntityA(IModelA modelA)
        {
            IEntityA entityA = GetIstanceOfRepositoryA.GetConcreteEntityA();
            entityA.Id = modelA.Id;
            entityA.Name = modelA.Name;
            entityA.Surname = modelA.Surname;
            return entityA;
        }
    }
}