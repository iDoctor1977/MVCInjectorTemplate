using Injector.Common.IEntity;

namespace Injector.Common.IRepository
{
    public interface IRepositoryA
    {
        IEntityA ReadEntity(int IdA);
        IEntityA ReadEntityByName(string name);
        void CreateEntity(IEntityA entityA);
        void UpdateEntity(IEntityA entityA);
        void DeleteEntity(IEntityA entityA);
        void Commit();
        IEntityA GetConcreteEntityA();
        string ToStringRepository();
    }
}