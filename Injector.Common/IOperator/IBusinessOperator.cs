using Injector.Common.IEntity;
using Injector.Common.IModel;

namespace Injector.Common.IOperator
{
    public interface IBusinessOperator
    {
        IDataModel GetModel(int id);
        void AddModel(IDataModel model);
        void EditModel(IDataModel model);
        void DeleteModel(IDataModel model);
        string ToStringOperator();
        IDataModel ConvertToDataModel(IDataEntity entity);
    }
}