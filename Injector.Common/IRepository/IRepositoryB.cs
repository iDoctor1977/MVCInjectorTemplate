using Injector.Common.IEntity;

namespace Injector.Common.IRepository
{
    public interface IRepositoryB
    {
        IEntityB ReadEntity(int id);
        IEntityB ReadEntityByUsername(string username);
        void CreateEntity(IEntityB entityB);
        void UpdateEntity(IEntityB entityB);
        void DeleteEntity(IEntityB entityB);
        void Commit();
        IEntityB GetConcreteEntityB();
        string ToStringRepository();
    }
}