using Injector.Common.IEntity;

namespace Injector.Common.IRepository
{
    public interface IRepositoryB
    {
        IEntityB ReadEntityById(int id);
        IEntityB ReadEntityByUsername(string username);
        void CreateEntity(IEntityB entityB);
        void UpdateEntity(IEntityB entityB);
        void DeleteEntity(IEntityB entityB);
        IEntityB GetConcreteEntityB();
        void Commit();
        string ToStringRepository();
    }
}