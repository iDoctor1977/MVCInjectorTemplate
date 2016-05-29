using Injector.Common.IEntity;
using Injector.Common.IModel;

namespace Injector.Common.IRepository
{
    public interface IRepositoryB
    {
        void Commit();
        IEntityB GetEntity(int id);
        void AddEntity(IEntityB entity);
        void EditEntity(IEntityB entity);
        void DeleteEntity(IEntityB entity);
        string ToStringRepository();
        IEntityB ConvertToDataEntity(IModelB model);
    }
}