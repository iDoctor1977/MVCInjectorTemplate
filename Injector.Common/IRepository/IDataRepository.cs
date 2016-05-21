using Injector.Common.IEntity;
using Injector.Common.IModel;

namespace Injector.Common.IRepository
{
    public interface IDataRepository
    {
        void Commit();
        IDataEntity GetEntity(int id);
        void AddEntity(IDataEntity entity);
        void EditEntity(IDataEntity entity);
        void DeleteEntity(IDataEntity entity);
        string ToStringRepository();
        IDataEntity ConvertToDataEntity(IDataModel model);
    }
}