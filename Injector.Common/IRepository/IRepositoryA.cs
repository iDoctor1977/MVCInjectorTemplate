using Injector.Common.IEntity;
using Injector.Common.IModel;

namespace Injector.Common.IRepository
{
    public interface IRepositoryA
    {
        void Commit();
        IEntityA GetEntity(int id);
        void AddEntity(IEntityA entity);
        void EditEntity(IEntityA entity);
        void DeleteEntity(IEntityA entity);
        string ToStringRepository();
        IEntityA ConvertToDataEntity(IModelA model);
    }
}